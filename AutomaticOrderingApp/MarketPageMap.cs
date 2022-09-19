﻿using OpenQA.Selenium;

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
    }
}
