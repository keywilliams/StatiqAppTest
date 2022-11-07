using Statiq.Sass;

namespace GeneratePagoFromBlazor.Pipelines
{
    public class ScssScriptPipeline : Pipeline
    {
        public ScssScriptPipeline()
        {
            InputModules = new ModuleList
            {
              new ReadFiles("wwwroot/scss/*.scss"),
              new ReadFiles("wwwroot/css/*.scss")
            };

            ProcessModules = new ModuleList
            {
                new CompileSass()
                .GenerateSourceMap()
                .WithCompressedOutputStyle()
            };

            OutputModules = new ModuleList
            {
                new WriteFiles()
            };
        }
    }
}
