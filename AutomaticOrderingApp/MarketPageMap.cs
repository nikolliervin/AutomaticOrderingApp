using OpenQA.Selenium;

namespace AutomaticOrderingApp
{
    public class MarketPageMap
    {
        public By SearchBar => By.XPath("//*[@id='s']");

        public By SearchBtn => By.XPath("//*[@id='searchform']/div/button");
    }
}
