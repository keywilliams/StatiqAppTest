using GeneratePagoFromBlazor.Models;

namespace GeneratePagoFromBlazor.Services
{
    public class TmcService
    {
        public TmcService()
        {

        }

        public List<SiteColor> GetSiteColors()
        {
            var colors = new List<SiteColor>
            {
                new SiteColor("MainColor", "red"),
                new SiteColor("BackgroundColor", "blue")
            };

            return colors;
        }
    }
}
