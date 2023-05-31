using SearchTestFramework.Util;

namespace SearchTestFramework.Constants
{
    internal static class Constants
    {
        public static readonly string BaseUrl = PropertyReader.GetPropertyValue("baseUrl");
        public static readonly TimeSpan ExplicitWait = TimeSpan.FromSeconds(int.Parse(PropertyReader.GetPropertyValue("explicitWaitSeconds")));
    }
}