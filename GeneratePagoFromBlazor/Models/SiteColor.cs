namespace TMC.Backend.Business.Customers.Models
{
    public class SiteColor
    {
        public SiteColor(string tag, string color)
        {
            this.Tag = tag;
            this.Color = color;
        }

        public string Tag { get; set; }

        public string Color { get; set; }
    }
}
