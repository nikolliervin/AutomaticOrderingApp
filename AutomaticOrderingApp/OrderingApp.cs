using System.Collections.Generic;
using System.Linq;

namespace AutomaticOrderingApp
{
    internal class OrderingApp
    {

        static void Main(string[] args)
        {
            var Steps = new Steps();

            var Products = new Products();

            Steps.LandingOnThePage();

            /*foreach (var item in Products.products)
            {
                Steps.SearchProduct(item.Key);
                Steps.CheckProductName(item.Key);
                Steps.AddProductToChart();
            }*/

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





        }
    }
}
