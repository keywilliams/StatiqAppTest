namespace TMC.Backend.Business.Customers.Models
{
    public class SiteModel
    {
        public string InputUrlZipFile { get; set; }
        public string OutputFolder { get; set; }

        public SiteModel(string inputUrlZipFile, string outputFolder)
        {
            InputUrlZipFile = inputUrlZipFile;
            OutputFolder = outputFolder;
        }
    }
}
