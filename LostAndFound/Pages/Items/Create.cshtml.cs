using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LostAndFound.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace LostAndFound.Pages.Items
{
    public class CreateModel : PageModel
    {
        private readonly ItemContext _context;

        public CreateModel(ItemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Item Item { get; set; }
        public IFormFile FileData { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Item.Add(Item);
            await _context.SaveChangesAsync();

            // 保存先を取得
            string filePath = @"/Users/kobayashitatsuya/Desktop/LostAndFound/LostAndFound/wwwroot/upimage";
            System.IO.Stream stream = FileData.OpenReadStream();
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, (int)stream.Length);

            System.IO.FileStream fs = new System.IO.FileStream(filePath + FileData.FileName, System.IO.FileMode.CreateNew);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();
            stream.Close();

            return RedirectToPage("./Index");
        }
    }

}
