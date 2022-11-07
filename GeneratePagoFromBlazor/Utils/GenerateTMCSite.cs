using GeneratePagoFromBlazor.Services;
using Statiq.Razor;

namespace GeneratePagoFromBlazor.Utils
{
    public static class GenerateTMCSite
    {
        public static Bootstrapper GenerateTMCSiteByLanguage(this Bootstrapper bootstrapper)
        {
            var tmcService = new TmcService();
            var language = tmcService.GetTmcIndex();

            foreach (var index in language.IndexCollection)
            {
                bootstrapper.BuildPipeline($"Render TMC Index in {index.Key}", builder => builder
                    .WithInputReadFiles("Index.cshtml")
                    .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(index.Value)))
                    .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/Index.html")));

                foreach (var movie in index.Value.Movies)
                {
                    bootstrapper.BuildPipeline($"Render Movie {movie.Name} in {index.Key}", builder => builder
                        .WithInputReadFiles("MovieDetail.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(movie)))
                        .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{movie.Name}.html")));
                }

                //foreach (var tv in index.Value.Tvs)
                //{
                //    bootstrapper.BuildPipeline($"Render IndexItem {item.Name} in {index.Key}", builder => builder
                //        .WithInputReadFiles("IndexItem.cshtml")
                //        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(item)))
                //        .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{item.Name}.html")));
                //}

                //foreach (var audio in index.Value.Audios)
                //{
                //    bootstrapper.BuildPipeline($"Render IndexItem {item.Name} in {index.Key}", builder => builder
                //        .WithInputReadFiles("IndexItem.cshtml")
                //        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(item)))
                //        .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{item.Name}.html")));
                //}
            }

            return bootstrapper;
        }
    }
}
