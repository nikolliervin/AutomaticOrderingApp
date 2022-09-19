using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace AutomaticOrderingApp
{
    internal class Steps : MarketPageMap
    {
        IWebDriver driver = new ChromeDriver();
        private string URL = ConfigurationManager.AppSettings["StoreURL"];

        public void LandingOnThePage()
        {
            driver.Navigate().GoToUrl(URL);
        }

    }
}
