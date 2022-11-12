﻿namespace GeneratePagoFromBlazor.Models
{
    public class BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ContentType ContentType { get; set; }
        public decimal ImdbRating { get; set; }
        public int Year { get; set; }
        public string Image { get; set; }
        public string BannerImage { get; set; }
    }
}