using GeneratePagoFromBlazor.Services;
using Statiq.Razor;
using System.Text.Json;

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
                string path = $"{index.Language}/";
                string resourcePath = "../";
                if (index.Order == 1)//The firts language will use the root folder
                {
                    path = "";
                    resourcePath = "";
                }

                index.IndexView.Total = (index.IndexView.Movies.Count + index.IndexView.Audios.Count + index.IndexView.Tvs.Count);

                bootstrapper.GenerateJsonFile(JsonSerializer.Serialize(index), path);

                index.IndexView.ResourcePath = resourcePath;
                bootstrapper.BuildPipeline($"Render TMC Index in {index.Language}", builder => builder
                    .WithInputReadFiles("Index.cshtml")
                    .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(index.IndexView)))
                    .WithOutputWriteFiles(new NormalizedPath($"{path}{index.IndexView.HtmlName}.html")));

                index.IndexView.FAQ.ResourcePath = resourcePath;
                bootstrapper.BuildPipeline($"Render FAQs in {index.Language}", builder => builder
                        .WithInputReadFiles("FAQs.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(index.IndexView.FAQ)))
                        .WithOutputWriteFiles(new NormalizedPath($"{path}{index.IndexView.FAQ.HtmlName}.html")));

                foreach (var movie in index.IndexView.Movies)
                {
                    movie.Related = index.IndexView.Movies.Where(m => m.Genres.Any(x => movie.Genres.Any(y => y == x)) && movie != m).ToList();
                    movie.AllMovies = index.IndexView.Movies;
                    movie.ResourcePath = resourcePath;

                    bootstrapper.BuildPipeline($"Render Movie {movie.Name} in {index.Language}", builder => builder
                        .WithInputReadFiles("MovieDetail.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(movie)))
                        .WithOutputWriteFiles(new NormalizedPath($"{path}{movie.HtmlName}.html")));
                }

                foreach (var tv in index.IndexView.Tvs)
                {
                    tv.Related = index.IndexView.Tvs.Where(m => m.Genres.Any(x => tv.Genres.Any(y => y == x)) && tv != m).ToList();
                    tv.AllTvs = index.IndexView.Tvs;
                    tv.ResourcePath = resourcePath;

                    bootstrapper.BuildPipeline($"Render Tv {tv.Name} season {tv.Season} in {index.Language}", builder => builder
                        .WithInputReadFiles("TvDetail.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(tv)))
                        .WithOutputWriteFiles(new NormalizedPath($"{path}{tv.HtmlName}.html")));
                }

                foreach (var audio in index.IndexView.Audios)
                {
                    audio.Related = index.IndexView.Audios.Where(a => audio != a).ToList();
                    audio.AllAudios = index.IndexView.Audios;
                    audio.ResourcePath = resourcePath;

                    bootstrapper.BuildPipeline($"Render Audio {audio.Name} in {index.Language}", builder => builder
                        .WithInputReadFiles("AudioDetail.cshtml")
                        .WithProcessModules(new RenderRazor().WithModel(Config.FromValue(audio)))
                        .WithOutputWriteFiles(new NormalizedPath($"{path}{audio.HtmlName}.html")));
                }
            }

            return bootstrapper;
        }

        public static Bootstrapper GenerateJsonFile(this Bootstrapper bootstrapper, string json, string language)
        {
            bootstrapper
                .ConfigureFileSystem(
                    (fileSystem, settings, serviceCollection) =>
                    {
                        var inputFolder = fileSystem.InputPaths.FirstOrDefault();

                        string path = $"{inputFolder.FullPath}/{language}";

                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);

                        string fileFullPath = $"{path}data.json";

                        if (File.Exists(fileFullPath))
                            File.Delete(fileFullPath);

                        File.WriteAllText(fileFullPath, json);
                    }
                );

            return bootstrapper;
        }
    }
}
