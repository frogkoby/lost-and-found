using System;
namespace LostAndFound.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Coordinate { get; set; }
    }
}
