using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LostAndFound.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace LostAndFound.Pages.Items
{
    public class IndexModel : PageModel
    {

        private readonly ItemContext _context;

        public IndexModel(ItemContext context)
        {
            _context = context;

        }

        public IList<Item> Item { get;set; }


        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
    public static class JsonSerializer
    {

        public static JsonSerializerOptions Run()
        {
            return new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
        }
    }

}
