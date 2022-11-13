using GeneratePagoFromBlazor.Services;

namespace GeneratePagoFromBlazor.Utils
{
    public static class GenerateScss
    {
        public static Bootstrapper GenerateScssFiles(this Bootstrapper bootstrapper)
        {
            bootstrapper
                .ConfigureFileSystem(
                    (fileSystem, settings, serviceCollection) =>
                    {
                        var tmcService = new TmcService();
                        var colors = tmcService.GetSiteColors();

                        var filePathTemplate = fileSystem.RootPath.Combine("input/wwwroot/scss/_template.scss");
                        if (File.Exists(filePathTemplate.FullPath))
                        {
                            string fileTemplate = File.ReadAllText(filePathTemplate.FullPath);

                            foreach (var color in colors)
                            {
                                fileTemplate = fileTemplate.Replace($"[{color.Tag}]", color.Color);
                            }

                            var filePath = fileSystem.RootPath.Combine("input/wwwroot/scss/_colors.scss");

                            using (var writer = new StreamWriter(filePath.FullPath, false))
                            {
                                writer.WriteLine(fileTemplate);
                            }
                        }
                    }
                );

            return bootstrapper;
        }
    }
}
