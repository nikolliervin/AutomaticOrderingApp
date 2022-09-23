using OpenQA.Selenium;

namespace AutomaticOrderingApp
{
    public class MarketPageMap
    {
        public By SearchBar => By.XPath("//*[@id='s']");

        public By SearchBtn => By.XPath("//*[@id='searchform']/div/button");

        public By ProductName => By.XPath("//*[@id='products_List']/div/div[1]/div/a[2]/span[1]");

        public By AddToChart => By.XPath("//*[@id='addtoCart']");

        public By ChartBtn => By.XPath("//*[@id='main_header']/div[1]/div/div[3]/a[1]");

        public By LookAtChartBtn => By.XPath("//*[@id='woocommerce_widget_cart-2']/div/p[2]/a[1]");

        public By AmountInput(int option) => By.XPath($"//*[@id='inner_page']/div/div/div/div/form/table/tbody/tr[{option}]/td[5]/div/input");

        public By TitlePageToClick => By.XPath("//*[@id='inner_page']/div/div/div/h2");

        public By RefreshChartBtn => By.XPath("//*[@id='inner_page']/div/div/div/div/form/table/tbody/tr[12]/td/button");

        public By CheckoutDetailsBtn => By.XPath("//*[@id='inner_page']/div/div/div/div/div[2]/div/div/a");

        public By FirstName => By.XPath("//*[@id='billing_first_name']");
        public By LastName => By.XPath("//*[@id='billing_last_name']");
        public By Street => By.XPath("//*[@id='billing_address_1']");
        public By Appartment => By.XPath("//*[@id='billing_address_2']");

        public By City => By.XPath("//*[@id='billing_city']");

        public By PhoneNumber => By.XPath("//*[@id='billing_phone']");

        public By Email => By.XPath("//*[@id='billing_email']");

        public By CreditCardPayment => By.XPath("//*[@id='payment_method_bacs']");
        public By CashPayment => By.XPath("//*[@id='payment_method_cod']");


    }
}
