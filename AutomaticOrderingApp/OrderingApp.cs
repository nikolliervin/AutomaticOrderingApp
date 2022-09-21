namespace AutomaticOrderingApp
{
    internal class OrderingApp
    {

        static void Main(string[] args)
        {
            var Steps = new Steps();

            var Products = new Products();

            Steps.LandingOnThePage();

            foreach (var item in Products.products)
            {
                Steps.SearchProduct(item.Key);
                Steps.CheckProductName(item.Key);
                Steps.AddProductToChart();
            }

            Steps.ViewChart();
            Steps.SetAmounts(Products.products);
            Steps.RefreshChart();





        }
    }
}
