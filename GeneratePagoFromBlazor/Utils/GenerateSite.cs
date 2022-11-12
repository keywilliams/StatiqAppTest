using GeneratePagoFromBlazor.Services;
using Statiq.Razor;

namespace GeneratePagoFromBlazor.Utils
{
    public static class GenerateSite
    {
        public static Bootstrapper GenerateSiteByLanguage(this Bootstrapper bootstrapper)
        {
            var tmcService = new TmcService();
            var language = tmcService.GetTmcIndex();

            foreach (var index in language.IndexCollection)
            {
                bootstrapper.BuildPipeline($"Render Index in {index.Key}", builder => builder
                    .WithInputReadFiles("Index.cshtml")
                    .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(index.Value)))
                    .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/Index.html")));

                //bootstrapper.BuildPipeline($"Render Privacy in {index.Key}", builder => builder
                //    .WithInputReadFiles("Privacy.cshtml")
                //    .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(index.Value.Privacy)))
                //    .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/Privacy.html")));

                foreach (var item in index.Value.Movies)
                {
                    bootstrapper.BuildPipeline($"Render IndexItem {item.Name} in {index.Key}", builder => builder
                        .WithInputReadFiles("IndexItem.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(item)))
                        .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{item.Name}.html")));
                }

                foreach (var item in index.Value.Tvs)
                {
                    bootstrapper.BuildPipeline($"Render IndexItem {item.Name} in {index.Key}", builder => builder
                        .WithInputReadFiles("IndexItem.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(item)))
                        .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{item.Name}.html")));
                }

                foreach (var item in index.Value.Audios)
                {
                    bootstrapper.BuildPipeline($"Render IndexItem {item.Name} in {index.Key}", builder => builder
                        .WithInputReadFiles("IndexItem.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(item)))
                        .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{item.Name}.html")));
                }
            }

            return bootstrapper;
        }
    }
}
