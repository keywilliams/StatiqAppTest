using GeneratePagoFromBlazor.Pipelines;

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
                                     //.DownloadInputFiles(new Uri("https://github.com/keywilliams/StatiqAppTest/raw/master/input.zip"))
                                     //.GenerateScssFiles()
                                     //.GenerateSiteByLanguage()
                                     .AddWeb()
                                     .RunAsync();
        }
    }
}