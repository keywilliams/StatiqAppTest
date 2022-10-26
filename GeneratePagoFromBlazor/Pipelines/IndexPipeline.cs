using GeneratePagoFromBlazor.Models;
using Statiq.Razor;

namespace GeneratePagoFromBlazor.Pipelines
{
    public class IndexPipeline : Pipeline
    {
        public IndexPipeline()
        {
            InputModules = new ModuleList
            {
                new ReadFiles("index.cshtml")
            };

            ProcessModules = new ModuleList {
                new RenderRazor().WithModel(Config.FromDocument((doc, context) =>
                {
                    return new IndexViewModel();
                })),
                new SetDestination(Config.FromDocument((doc, ctx) => {
                    return new NormalizedPath("index.html");
                }))
            };

            OutputModules = new ModuleList {
                new WriteFiles()
            };
        }
    }
}
