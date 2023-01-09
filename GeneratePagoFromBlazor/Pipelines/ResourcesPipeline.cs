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
                // Misc
                new CopyFiles("wwwroot/*.svg"),
                new CopyFiles("wwwroot/*.ico"),
                // Images
                new CopyFiles("wwwroot/img/**"),
                // Libs
                new CopyFiles("wwwroot/lib/**"),
                // CSS
                new CopyFiles("wwwroot/css/bootstrap/**"),
                new CopyFiles("wwwroot/css/open-iconic/**"),
                //JSON
                new CopyFiles("*.json"),
                new CopyFiles("**/*.json")
            };
        }
    }
}
