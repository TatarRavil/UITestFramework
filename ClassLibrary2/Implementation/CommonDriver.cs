using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace CommonLibs.Implementation
{
    public class CommonDriver
    {
        public IWebDriver Driver { get; private set; }
        public int PageLoadTimeout { private get => pageLoadTimeout; set => pageLoadTimeout = value; }
        public int ElementDetectionTimeout { private get => elementDetectionTimeout; set => elementDetectionTimeout = value; }

        private int pageLoadTimeout;
        private int elementDetectionTimeout;

        public CommonDriver(string browserType)
        {
            browserType = browserType.ToLower().Trim();

            pageLoadTimeout = 60;
            ElementDetectionTimeout = 10;

            switch (browserType)
            {
                case "chrome":
                    Driver = new ChromeDriver();
                    break;
                case "edge":
                    Driver = new EdgeDriver();
                    break;
                default:
                    throw new Exception("invalid browser type");
            }
        }

        public void NavigateToFirstURL(string url)
        {
            url = url.Trim();

            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadTimeout);

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(elementDetectionTimeout);

            Driver.Url = url;
        }

        public string GetPageTittle()
        {
            return Driver.Title;
        }

        public void CloseBrowser()
        {
            if (Driver != null) { Driver.Close(); }
        }

        public void CloseAllBrowsers()
        {
            if (Driver != null) { Driver.Quit(); }
        }
    }
}