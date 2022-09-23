using System.Collections.Generic;
using System.Linq;

namespace AutomaticOrderingApp
{
    internal class OrderingApp
    {

        static void Main(string[] args)
        {
            //   ToDo: 
            //    1)Inspect headless mode
            //    2)Set the app to run automatically
            var Steps = new Steps();

            var Products = new Products();

            Steps.LandingOnThePage();

            for (int i = 1; i < Products.products.Count; i++)
            {
                KeyValuePair<string, int> product = Products.products.ElementAt(i);

                Steps.SearchProduct(product.Key);
                Steps.CheckProductName(product.Key);
                Steps.AddProductToChart();

            }

            Steps.ViewChart();
            Steps.SetAmounts(Products.products);
            Steps.RefreshChart();
            Steps.GetCheckOut();
            Steps.SetCheckoutDetails();
            Steps.SelectPaymentMethod();
            Steps.SetOrder();





        }
    }
}
