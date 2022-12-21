namespace TMC.Backend.Business.Customers.Models
{
    public class AudioDetailModel : BaseModel
    {
        public string Season { get; set; }
        public List<Track> TrackList { get; set; }
        public List<AudioDetailModel> Related { get; set; }
        public List<AudioDetailModel> AllAudios { get; set; }
    }

    public class Track
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
    }
}
