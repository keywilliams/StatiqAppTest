namespace TMC.Backend.Business.Customers.Models
{
    public class BaseModel : LayoutModel
    {
        public string Description { get; set; }
        public ContentType ContentType { get; set; }
        public string ImdbRating { get; set; }
        public int Year { get; set; }
        public string Image { get; set; }
        public string BannerImage { get; set; }
        public string DefaultTrailerUrl { get; set; }
        public string ImdbId { get; set; }
        public string Rating { get; set; }
        public string Duration { get; set; }
        public string Category { get; set; }
        public string SliderImage { get; set; }
        public string SliderBackgroundImage { get; set; }
    }
}
