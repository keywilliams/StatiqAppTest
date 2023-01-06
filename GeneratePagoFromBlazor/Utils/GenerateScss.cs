namespace GeneratePagoFromBlazor.Utils
{
    public static class GenerateScss
    {
        public static Bootstrapper GenerateScssFiles(this Bootstrapper bootstrapper, string backgroundColor, string primaryColor, string secondaryColor, string textColor)
        {
            bootstrapper
                .ConfigureFileSystem(
                    (fileSystem, settings, serviceCollection) =>
                    {
                        var filePathTemplate = fileSystem.RootPath.Combine("input/wwwroot/css/scss/variables/_template.scss");
                        if (File.Exists(filePathTemplate.FullPath))
                        {
                            string fileTemplate = File.ReadAllText(filePathTemplate.FullPath);

                            fileTemplate = fileTemplate.Replace("[BackgroundColor]", backgroundColor);
                            fileTemplate = fileTemplate.Replace("[PrimaryColor]", primaryColor);
                            fileTemplate = fileTemplate.Replace("[SecondaryColor]", secondaryColor);
                            fileTemplate = fileTemplate.Replace("[TextColor]", textColor);

                            var filePath = fileSystem.RootPath.Combine("input/wwwroot/css/scss/variables/_colors.scss");

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
