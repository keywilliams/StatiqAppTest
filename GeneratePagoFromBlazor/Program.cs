using GeneratePagoFromBlazor.Pipelines;
using GeneratePagoFromBlazor.Utils;

namespace GeneratePagoFromBlazor
{
    class Program
    {
        public static async Task<int> Main(string[] args)
        {
            return await Bootstrapper.Factory
                                     .CreateDefault(args)
                                     .AddPipeline<JavaScriptPipeline>()
                                     .AddPipeline<CssScriptPipeline>()
                                     .AddPipeline<ResourcesPipeline>()
                                     .AddPipeline<ScssScriptPipeline>()
                                     .DownloadInputFiles(new Uri("https://github.com/keywilliams/StatiqAppTest/raw/master/input.zip"))
                                     .GenerateScssFiles()
                                     .GenerateSiteByLanguage()
                                     .RunAsync();
        }

        //private static void AddPipelines(Bootstrapper bootstrapper)
        //{
        //    var tmcService = new TmcService();
        //    var language = tmcService.GetIndex();

        //    foreach (var index in language.IndexCollection)
        //    {
        //        bootstrapper.BuildPipeline($"Render Index in {index.Key}", builder => builder
        //            .WithInputReadFiles("Index.cshtml")
        //            .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(index.Value)))
        //            .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/Index.html")));

        //        bootstrapper.BuildPipeline($"Render Privacy in {index.Key}", builder => builder
        //            .WithInputReadFiles("Privacy.cshtml")
        //            .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(index.Value.Privacy)))
        //            .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/Privacy.html")));

        //        foreach (var item in index.Value.Items)
        //        {
        //            bootstrapper.BuildPipeline($"Render IndexItem {item.Name} in {index.Key}", builder => builder
        //                .WithInputReadFiles("IndexItem.cshtml")
        //                .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(item)))
        //                .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{item.Name}.html")));
        //        }
        //    }
        //}
    }
}