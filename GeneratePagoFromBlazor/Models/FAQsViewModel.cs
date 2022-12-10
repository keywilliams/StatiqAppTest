namespace GeneratePagoFromBlazor.Models
{
    public class FAQsViewModel : BaseModel
    {
        public List<FAQ> FAQs { get; set; }
    }

    public class FAQ
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public List<FAQItem> FAQItems { get; set; }
    }

    public class FAQItem
    {
        public int Order { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
