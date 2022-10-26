using Statiq.Minification;

namespace GeneratePagoFromBlazor.Pipelines
{
    public class CssScriptPipeline : Pipeline
    {
        public CssScriptPipeline()
        {
            InputModules = new ModuleList
            {
              new ReadFiles("wwwroot/css/*.css")
            };

            PostProcessModules = new ModuleList
            {
                new MinifyCss(),
                new SetDestination(".css")
            };

            OutputModules = new ModuleList
            {
                new WriteFiles()
            };
        }
    }
}
