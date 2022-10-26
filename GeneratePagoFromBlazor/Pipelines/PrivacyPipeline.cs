using GeneratePagoFromBlazor.Models;
using Statiq.Razor;

namespace GeneratePagoFromBlazor.Pipelines
{
    public class PrivacyPipeline : Pipeline
    {
        public PrivacyPipeline()
        {
            InputModules = new ModuleList
            {
                new ReadFiles("Privacy.cshtml")
            };

            ProcessModules = new ModuleList {
                new RenderRazor().WithModel(Config.FromDocument((doc, context) =>
                {
                    return new PrivacyViewModel() {
                        Name = "WIG 2",
                        Data = DateTime.UtcNow
                    };
                })),
                new SetDestination(Config.FromDocument((doc, ctx) => {
                    return new NormalizedPath("Privacy.html");
                }))
            };

            OutputModules = new ModuleList {
                new WriteFiles()
            };
        }
    }
}
