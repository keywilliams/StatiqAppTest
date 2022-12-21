namespace TMC.Backend.Business.Customers.Models
{
    public class TvDetailModel : BaseModel
    {
        public string Director { get; set; }
        public string Cast { get; set; }
        public string Studio { get; set; }

        public List<string> Genres { get; set; }
        public string Genre { get; set; }
        public string Released { get; set; }
        public string Copyright { get; set; }
        public int Season { get; set; }

        public List<Episode> Episodes { get; set; }
        public List<TvDetailModel> Related { get; set; }
        public List<TvDetailModel> AllTvs { get; set; }
    }

    public class Episode
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
    }
}
