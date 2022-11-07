using GeneratePagoFromBlazor.Pipelines;
using GeneratePagoFromBlazor.Utils;

namespace GeneratePagoFromBlazor
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            //await Bootstrapper.Factory
            //                         .CreateDefault(args)
            //                         .AddPipeline<JavaScriptPipeline>()
            //                         .AddPipeline<CssScriptPipeline>()
            //                         .AddPipeline<ResourcesPipeline>()
            //                         .AddPipeline<ScssScriptPipeline>()
            //                         //.DownloadInputFiles(new Uri("https://github.com/keywilliams/StatiqAppTest/raw/master/input.zip"))
            //                         //.GenerateScssFiles()
            //                         //.GenerateSiteByLanguage()
            //                         .AddWeb()
            //                         .RunAsync();

            await Bootstrapper.Factory
                                     .CreateDefault(args)
                                     .AddPipeline<JavaScriptPipeline>()
                                     .AddPipeline<CssScriptPipeline>()
                                     .AddPipeline<ResourcesPipeline>()
                                     .AddPipeline<ScssScriptPipeline>()
                                     .DownloadInputFiles(new Uri("https://github.com/keywilliams/StatiqAppTest/raw/master/Input2.zip"))
                                     //.GenerateScssFiles()
                                     //.GenerateSiteByLanguage()
                                     .AddWeb()
                                     .RunAsync();
            return;
        }
    }
}