namespace GeneratePagoFromBlazor.Models
{
    public class IndexModel
    {
        public List<AudioDetailModel> Audios { get; set; }
        public List<MovieDetailModel> Movies { get; set; }
        public List<TvDetailModel> Tvs { get; set; }

        public List<Item> Categories { get; set; }
        public List<Item> Genres { get; set; }
        public List<Item> Languages { get; set; }
        public List<Item> Subtitles { get; set; }
        public List<Item> SortBy { get; set; }
        public List<Item> Dates { get; set; }
        public List<Item> From { get; set; }
        public List<Item> To { get; set; }
        public List<Item> FlightNumber { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Item(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
