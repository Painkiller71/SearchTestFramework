using System.Reflection;

namespace SearchTestFramework.Util
{
    internal class PropertyReader
    {
        public static string GetPropertyValue(string propertyName)
        {
            var path = Assembly.GetCallingAssembly().Location;
            if (path == null) return null;
            var actualPath = path[..path.LastIndexOf("bin", StringComparison.Ordinal)];
            var projectPath = new Uri(actualPath).LocalPath;
            var reportPath = projectPath + "\\App.properties";
            var data = File.ReadAllLines(reportPath)
                .ToDictionary(row => row.Split('=')[0],
                    row => string.Join("=", row.Split('=').Skip(1).ToArray()));
            return data[propertyName];
        }
    }
}