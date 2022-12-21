using GeneratePagoFromBlazor.Services;
using Statiq.Razor;

namespace GeneratePagoFromBlazor.Utils
{
    public static class GenerateTMCSite
    {
        public static Bootstrapper GenerateTMCSiteByLanguage(this Bootstrapper bootstrapper)
        {
            var tmcService = new TmcService();
            var languages = tmcService.GetSiteLanguages();
            var tmcDataByLanguage = tmcService.GetTmcIndex(languages);

            foreach (var index in tmcDataByLanguage.IndexCollection)
            {
                index.Value.Total = (index.Value.Movies.Count + index.Value.Audios.Count + index.Value.Tvs.Count);
                bootstrapper.BuildPipeline($"Render TMC Index in {index.Key}", builder => builder
                    .WithInputReadFiles("Index.cshtml")
                    .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(index.Value)))
                    .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{index.Value.Name}.html")));

                foreach (var movie in index.Value.Movies)
                {
                    movie.Related = index.Value.Movies;
                    movie.AllMovies = index.Value.Movies;
                    bootstrapper.BuildPipeline($"Render Movie {movie.Name} in {index.Key}", builder => builder
                        .WithInputReadFiles("MovieDetail.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(movie)))
                        .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{movie.Name}.html")));
                }

                foreach (var tv in index.Value.Tvs)
                {
                    tv.Related = index.Value.Tvs;
                    tv.AllTvs = index.Value.Tvs;
                    bootstrapper.BuildPipeline($"Render Tv {tv.Name} in {index.Key}", builder => builder
                        .WithInputReadFiles("TvDetail.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(tv)))
                        .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{tv.Name}.html")));
                }

                foreach (var audio in index.Value.Audios)
                {
                    audio.Related = index.Value.Audios;
                    audio.AllAudios = index.Value.Audios;
                    bootstrapper.BuildPipeline($"Render Audio {audio.Name} in {index.Key}", builder => builder
                        .WithInputReadFiles("AudioDetail.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(audio)))
                        .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/{audio.Name}.html")));
                }

                foreach (var faq in index.Value.FAQs)
                {
                    bootstrapper.BuildPipeline($"Render faq {faq.Title} in {index.Key}", builder => builder
                        .WithInputReadFiles("FAQs.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(faq)))
                        .WithOutputWriteFiles(new NormalizedPath($"{index.Key}/FAQs.html")));
                }
            }

            return bootstrapper;
        }
    }
}
