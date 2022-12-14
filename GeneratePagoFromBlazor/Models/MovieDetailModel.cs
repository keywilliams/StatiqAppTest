namespace TMC.Backend.Business.Customers.Models
{
    public class MovieDetailModel : BaseModel
    {
        public string Director { get; set; }
        public string Cast { get; set; }
        public string Studio { get; set; }
        public List<string> Genres { get; set; }
        public string Genre { get; set; }
        public string Released { get; set; }
        public string Copyright { get; set; }
        public List<MovieDetailModel> Related { get; set; }
        public List<MovieDetailModel> AllMovies { get; set; }
    }
}
