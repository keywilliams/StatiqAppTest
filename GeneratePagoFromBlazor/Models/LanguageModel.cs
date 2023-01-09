namespace TMC.Backend.Business.Customers.Models
{
    public class LanguageModel
    {
        public List<LanguageItem> IndexCollection { get; set; }
    }

    public class LanguageItem
    {
        public int Order { get; set; }
        public string Language { get; set; }
        public IndexViewModel IndexView { get; set; }
    }
}
