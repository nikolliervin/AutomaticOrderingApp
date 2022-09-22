using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;

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

        public void SearchProduct(string product)
        {
            driver.FindElement(SearchBar).Clear();
            driver.FindElement(SearchBar).SendKeys(product);
            driver.FindElement(SearchBtn).Click();
        }

        public bool CheckProductName(string name)
        {
            return driver.FindElement(ProductName).Text == name;
        }

        public void AddProductToChart()
        {
            driver.FindElement(AddToChart).Click();

        }

        public void ViewChart()
        {
            driver.FindElement(ChartBtn).Click();
            Thread.Sleep(2000);
            driver.FindElement(LookAtChartBtn).Click();
        }

        public void SetAmounts(Dictionary<string, int> products)
        {
            for (int i = 1; i < products.Count; i++)
            {
                KeyValuePair<string, int> product = products.ElementAt(i);

                Thread.Sleep(1000);
                driver.FindElement(AmountInput(i)).Clear();


                driver.FindElement(AmountInput(i)).SendKeys(product.Value.ToString());



            }




        }

        public void RefreshChart()
        {
            driver.FindElement(RefreshChartBtn).Click();
        }

        public void GetCheckOut()
        {
            driver.FindElement(CheckoutDetailsBtn).Click();
        }


    }
}
