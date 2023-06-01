using Microsoft.Extensions.Configuration;
using SearchTestFramework.Models;

namespace SearchTestFramework.Util
{
    public static class ConfigurationManager
    {
        private static readonly IConfiguration _configuration;

        static ConfigurationManager()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public static SeleniumOptions GetSeleniumOptions()
        {
            return _configuration.GetSection(SeleniumOptions.Selenium).Get<SeleniumOptions>();
        }
    }
}