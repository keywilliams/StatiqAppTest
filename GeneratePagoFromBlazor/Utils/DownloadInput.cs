namespace GeneratePagoFromBlazor.Utils
{
    public static class DownloadInput
    {
        public static Bootstrapper DownloadInputFiles(this Bootstrapper bootstrapper, Uri uri)
        {
            bootstrapper
                .ConfigureFileSystem((fileSystem, settings, serviceCollection) =>
                {
                    var path = fileSystem.RootPath.Combine("input");

                    var directory = fileSystem.GetDirectory(path);
                    if (directory.Exists)
                        directory.Delete(true);

                    using var clientHandler = new HttpClientHandler();
                    using var client = new HttpClient(clientHandler, false)
                    {
                        Timeout = TimeSpan.FromSeconds(60),
                    };

                    client.DefaultRequestHeaders.Add("User-Agent", $"Mozilla/5.0 AppleWebKit/605.1.15 Chrome/87.0.4272.0 Safari/604.1 Edg/87.0.654.0");
                    using var responseStream = client
                        .GetStreamAsync(uri)
                        .ConfigureAwait(false)
                        .GetAwaiter()
                        .GetResult();

                    using var zipStream =
                        new System.IO.Compression.ZipArchive(responseStream,
                            System.IO.Compression.ZipArchiveMode.Read);

                    foreach (var entry in zipStream.Entries.Where(entry =>
                        !string.IsNullOrWhiteSpace(entry.Name)))
                    {
                        var parentPath = Path.GetDirectoryName(entry.FullName);
                        var fileDir = string.IsNullOrWhiteSpace(parentPath)
                            ? directory
                            : directory.GetDirectory(parentPath);

                        var file = fileDir.GetFile(entry.Name);
                        using var entryStream = entry.Open();
                        using var fileStream = file.Open(true);
                        entryStream.CopyTo(fileStream);
                    }
                });

            return bootstrapper;
        }
    }
}
