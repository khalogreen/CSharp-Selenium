
namespace CSharpSelenium.Configs
{
    public class UiSettings
    {
        public string Browser { get; set; } = "Chrome";
        public bool Headless { get; set; } = false;
        public int Timeout { get; set; } = 30;
        public string BaseUrl { get; set; } = "https://the-internet.herokuapp.com/";
    }
}
