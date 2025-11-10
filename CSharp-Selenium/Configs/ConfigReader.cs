using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Configs
{
    public interface IConfigReader
    {
        string Get(string key);
        int GetInt(string key, int defaultValue = 0);
        bool GetBool(string key, bool defaultValue = false);
        string Environment { get; }
    }
    public sealed class ConfigReader : IConfigReader
    {
        private readonly IConfigurationRoot _config;
        public string Environment { get; }
        public ConfigReader()
        {
            Environment = System.Environment.GetEnvironmentVariable("Test_ENV") ?? "Dev";
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("configs/appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"configs/appsettings.{Environment}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();
            Console.WriteLine($"[ConfigReader] Environment: {Environment}");
        }
        public IConfigurationSection GetSection(string sectionName)
        {
            return _config.GetSection(sectionName);
        }
        public string Get(string key) => _config[key] ?? string.Empty;
        public int GetInt(string key, int defaultValue = 0) => int.TryParse(_config[key], out var result) ? result : defaultValue;
        public bool GetBool(string key, bool defaultValue = false) => bool.TryParse(_config[key], out var result) ? result : defaultValue;
    }
}
