using System;
namespace LostAndFound.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Title { get; set; }//落とし物のタイトル
        public string Description { get; set; }//落とし物の説明
        public float Longitude { get; set; }//経度
        public float Latitude { get; set; }//緯度
        public string PhotoPass { get; set; }//落とし物を撮影した画像
        public int UserID { get; set; }//後々にログインID用
    }
}
