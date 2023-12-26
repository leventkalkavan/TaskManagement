using Microsoft.Extensions.Configuration;

namespace Persistence.Configurations;

public class APIConfiguration
{
    public static string? GetConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),
                "/Users/leventkalkavan/Desktop/TaskManagement/Presentation/WebAPI"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString("MSSQL");
        }
    }
}
