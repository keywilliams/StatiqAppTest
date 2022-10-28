using GeneratePagoFromBlazor.Services;

namespace GeneratePagoFromBlazor.Utils
{
    public static class GenerateScss
    {
        private static string GetScssTemplate()
        {
            string filePath = $"{Directory.GetCurrentDirectory()}\\input\\wwwroot\\scss\\_template.scss";
            return File.ReadAllText(filePath);
        }

        public static void Generate()
        {
            var tmcService = new TmcService();
            var colors = tmcService.GetSiteColors();
            var file = GetScssTemplate();
            foreach (var color in colors)
            {
                file = file.Replace($"[{color.Tag}]", color.Color);
            }

            SaveScssFile(file);
        }

        private static void SaveScssFile(string scssFile)
        {
            string filePath = $"{Directory.GetCurrentDirectory()}\\input\\wwwroot\\scss\\_colors.scss";

            using (var writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(scssFile);
            }

        }
    }
}
