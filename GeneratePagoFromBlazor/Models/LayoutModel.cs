namespace GeneratePagoFromBlazor.Models
{
    public class LayoutModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public List<Language> SiteLanguages { get; set; }


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
