namespace TMC.Backend.Business.Customers.Models
{
    public class LayoutModel
    {
        public string Name { get; set; }
        public string HtmlName { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public string OgTitle { get; set; }
        public string Robots { get; set; }
        public string Logo { get; set; }
        public List<Language> SiteLanguages { get; set; }
        public bool MainPage { get; set; } = false;
        public string CompanyName { get; set; }
        public Resource Resources { get; set; }
        public ModalModel Modal { get; set; }
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

    public class Resource
    {
        //DropDowns
        public string DropDownCategory { get; set; }
        public string DropDownGenre { get; set; }
        public string DropDownLanguage { get; set; }
        public string DropDownSubtitle { get; set; }
        public string DropDownSortby { get; set; }
        public string DropDownDate { get; set; }
        public string DropDownDateDeparture { get; set; }
        public string DropDownFrom { get; set; }
        public string DropDownTo { get; set; }
        public string DropDownFlightNumber { get; set; }

        //Buttons
        public string ButtonAllContent { get; set; }
        public string ButtonMovies { get; set; }
        public string ButtonSeries { get; set; }
        public string ButtonAudio { get; set; }
        public string ButtonSearch { get; set; }
        public string ButtonFilters { get; set; }
        public string ButtonClearAll { get; set; }
        public string ButtonEdit { get; set; }
        public string ButtonTrailer { get; set; }

        //Text
        public string TextSearchResults { get; set; }
        public string TextWhatsOnYourFlight { get; set; }
        public string TextWhatsOnMyFlight { get; set; }
        public string TextOverview { get; set; }
        public string TextCredits { get; set; }
        public string TextDirector { get; set; }
        public string TextCast { get; set; }
        public string TextInformation { get; set; }
        public string TextStudio { get; set; }
        public string TextGenre { get; set; }
        public string TextReleased { get; set; }
        public string TextCopyright { get; set; }
        public string TextRelated { get; set; }
        public string TextAllMovies { get; set; }
        public string TextMovie { get; set; }
        public string TextTV { get; set; }
        public string TextEpisodes { get; set; }
        public string TextAudio { get; set; }
        public string TextTrackList { get; set; }
        public string TextTitle { get; set; }
        public string TextAllAudio { get; set; }
        public string TextAllSeries { get; set; }
        public string TextQuestion { get; set; }
        public string TextAnswer { get; set; }
        public string FAQTitle { get; set; }
        public string FAQSubtitle { get; set; }
        public string FAQPageTitle { get; set; }

        //Tab
        public string TabDestination { get; set; }
        public string TabFlightNumber { get; set; }
    }
}
