using GeneratePagoFromBlazor.Pipelines;
using GeneratePagoFromBlazor.Services;
using GeneratePagoFromBlazor.Utils;

namespace GeneratePagoFromBlazor
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var tmcService = new TmcService();
            var siteConfigurations = tmcService.GetSiteConfigurations();

            foreach (var siteConfiguration in siteConfigurations)
            {
                await Bootstrapper.Factory
                                  .CreateDefault(args)
                                  .DownloadInputFiles(new Uri(siteConfiguration.InputUrlZipFile))
                                  .GenerateScssFiles()
                                  .GenerateTMCSiteByLanguage()
                                  .AddPipeline<JavaScriptPipeline>()
                                  .AddPipeline<CssScriptPipeline>()
                                  .AddPipeline<ResourcesPipeline>()
                                  .AddPipeline<ScssScriptPipeline>()
                                  .ConfigureFileSystem((fileSystem, settings) =>
                                      {
                                          var path = fileSystem.RootPath.Combine($"output/{siteConfiguration.OutputFolder}");
                                          if (!path.IsNullOrEmpty)
                                          {
                                              fileSystem.OutputPath = path;
                                          }
                                      })
                                  .RunAsync();

            }

            //await Bootstrapper.Factory
            //                         .CreateDefault(args)
            //                         .DownloadInputFiles(new Uri("https://github.com/keywilliams/StatiqAppTest/raw/master/input.zip"))
            //                         .GenerateScssFiles()
            //                         .GenerateSiteByLanguage()
            //                         .AddPipeline<JavaScriptPipeline>()
            //                         .AddPipeline<CssScriptPipeline>()
            //                         .AddPipeline<ResourcesPipeline>()
            //                         .AddPipeline<ScssScriptPipeline>()
            //                         .ConfigureFileSystem((fileSystem, settings) =>
            //                             {
            //                                 var path = fileSystem.RootPath.Combine("output/Teste");
            //                                 if (!path.IsNullOrEmpty)
            //                                 {
            //                                     fileSystem.OutputPath = path;
            //                                 }
            //                             })
            //                         .RunAsync();

            //await Bootstrapper.Factory
            //                         .CreateDefault(args)
            //                         .DownloadInputFiles(new Uri("https://github.com/keywilliams/StatiqAppTest/raw/master/input_tmc.zip"))
            //                         .GenerateScssFiles()
            //                         .AddPipeline<JavaScriptPipeline>()
            //                         .AddPipeline<CssScriptPipeline>()
            //                         .AddPipeline<ResourcesPipeline>()
            //                         .AddPipeline<ScssScriptPipeline>()
            //                         .GenerateTMCSiteByLanguage()
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