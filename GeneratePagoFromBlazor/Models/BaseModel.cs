namespace GeneratePagoFromBlazor.Models
{
    public class BaseModel : LayoutModel
    {
        public string Description { get; set; }
        public ContentType ContentType { get; set; }
        public decimal ImdbRating { get; set; }
        public int Year { get; set; }
        public string Image { get; set; }
        public string BannerImage { get; set; }
        public string CompanyName { get; set; }
    }
}
