using Microsoft.Extensions.Configuration;
using System.Collections.Specialized;
using System.Linq;

namespace System.Configuration
{
    // TODO: Replace this shim with actual Options class
    public static class ConfigurationManager
    {
        public static NameValueCollection AppSettings { get; }

        static ConfigurationManager()
        {
            AppSettings = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false)
                .Build()
                .GetSection("AppSettings")
                .GetChildren()
                .Aggregate(new NameValueCollection(), (acc, cur) =>
                {
                    acc.Add(cur.Key, cur.Value);
                    return acc;
                });
        }
    }
}
