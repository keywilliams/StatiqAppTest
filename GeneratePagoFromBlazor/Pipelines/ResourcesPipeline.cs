namespace GeneratePagoFromBlazor.Pipelines
{
    public class ResourcesPipeline : Pipeline
    {
        public ResourcesPipeline()
        {
            InputModules = new ModuleList
            {
              new ReadFiles()
            };

            ProcessModules = new ModuleList
            {
                // Images
                new CopyFiles("wwwroot/img/**"),
                // Libs
                new CopyFiles("wwwroot/lib/**"),
            };
        }
    }
}
