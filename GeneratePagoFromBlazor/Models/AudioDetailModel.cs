namespace GeneratePagoFromBlazor.Models
{
    public class AudioDetailModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<Track> TrackList { get; set; }
    }

    public class Track
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
    }
}
