namespace GeneratePagoFromBlazor.Models
{
    public class LayoutModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public string OgTitle { get; set; }
        public string Robots { get; set; }
        public List<Language> SiteLanguages { get; set; }

        public bool MainPage { get; set; } = false;
        public string Logo { get; set; }
        public string CompanyName { get; set; }
    }

    public class Language
    {
        public string Path { get; set; }
        public string Text { get; set; }

        public Language(string path, string text)
        {
            Path = path;
            Text = text;
        }
    }
}
