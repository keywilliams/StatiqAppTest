using GeneratePagoFromBlazor.Pipelines;
using GeneratePagoFromBlazor.Utils;

namespace GeneratePagoFromBlazor
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await Bootstrapper.Factory
                                     .CreateDefault(args)
                                     //.DownloadInputFiles(new Uri("https://github.com/keywilliams/StatiqAppTest/raw/master/input.zip"))
                                     .GenerateScssFiles()
                                     .GenerateSiteByLanguage()
                                     .AddPipeline<JavaScriptPipeline>()
                                     .AddPipeline<CssScriptPipeline>()
                                     .AddPipeline<ResourcesPipeline>()
                                     .AddPipeline<ScssScriptPipeline>()
                                     .ConfigureFileSystem((fileSystem, settings) =>
                                         {
                                             var path = fileSystem.RootPath.Combine("output/Teste");
                                             if (!path.IsNullOrEmpty)
                                             {
                                                 fileSystem.OutputPath = path;
                                             }
                                         })
                                     .RunAsync();

            //await Bootstrapper.Factory
            //                         .CreateDefault(args)
            //                         .AddPipeline<JavaScriptPipeline>()
            //                         .AddPipeline<CssScriptPipeline>()
            //                         .AddPipeline<ResourcesPipeline>()
            //                         .AddPipeline<ScssScriptPipeline>()
            //                         .DownloadInputFiles(new Uri("https://github.com/keywilliams/StatiqAppTest/raw/master/input_tmc.zip"))
            //                         //.GenerateSiteByLanguage()
            //                         .ConfigureFileSystem((fileSystem, settings) =>
            //                             {
            //                                 var path = fileSystem.RootPath.Combine("output/TMC");
            //                                 if (!path.IsNullOrEmpty)
            //                                 {
            //                                     fileSystem.OutputPath = path;
            //                                 }
            //                             })
            //                         .RunAsync();
            return;
        }
    }
}