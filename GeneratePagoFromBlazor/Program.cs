using GeneratePagoFromBlazor.Models;
using GeneratePagoFromBlazor.Pipelines;
using GeneratePagoFromBlazor.Utils;
using Statiq.Razor;

namespace GeneratePagoFromBlazor
{
    class Program
    {
        public static async Task<int> Main(string[] args)
        {
            GenerateScssFile();

            var bootstrapper = Bootstrapper.Factory
                                           .CreateDefault(args)
                                           .AddPipeline<IndexPipeline>()
                                           .AddPipeline<PrivacyPipeline>()
                                           .AddPipeline<JavaScriptPipeline>()
                                           .AddPipeline<CssScriptPipeline>()
                                           .AddPipeline<ResourcesPipeline>()
                                           .AddPipeline<ScssScriptPipeline>();

            AddPipelines(bootstrapper);

            return await bootstrapper.RunAsync();
        }

        private static void GenerateScssFile()
        {
            GenerateScss.Generate();
        }

        private static void AddPipelines(Bootstrapper bootstrapper)
        {
            var index = new IndexViewModel();
            foreach (var item in index.Items)
            {
                bootstrapper.BuildPipeline($"Render {item.Name}", builder => builder
                    .WithInputReadFiles("IndexItem.cshtml")
                    .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(item)))
                    .WithOutputWriteFiles(new NormalizedPath($"{item.Name}.html")));
            }
        }
    }
}