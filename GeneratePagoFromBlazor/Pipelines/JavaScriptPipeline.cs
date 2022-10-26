using Statiq.Minification;

namespace GeneratePagoFromBlazor.Pipelines
{
    public class JavaScriptPipeline : Pipeline
    {
        public JavaScriptPipeline()
        {
            InputModules = new ModuleList
            {
              new ReadFiles("wwwroot/js/*.js")
            };

            PostProcessModules = new ModuleList
            {
                new MinifyJs(),
                new SetDestination(".js")
            };

            OutputModules = new ModuleList
            {
                new WriteFiles()
            };
        }
    }
}
