namespace AutomaticOrderingApp
{
    internal class OrderingApp
    {

        static void Main(string[] args)
        {
            var Steps = new Steps();

            Steps.LandingOnThePage();

            Steps.SearchProduct("Barilla farfalle makarona");

            Steps.CheckProductName("Barilla farfalle makarona");

            Steps.AddProductToChart();



        }
    }
}
