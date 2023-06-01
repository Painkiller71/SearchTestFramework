namespace SearchTestFramework.Models
{
    public class SeleniumOptions
    {
        public const string Selenium = "Selenium";

        public string BaseUrl { get; set; } = string.Empty;
        public int TimeoutInSeconds { get; set; } = 0;
    }
}