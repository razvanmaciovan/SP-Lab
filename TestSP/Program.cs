namespace TestSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubComanda hanoi = new SubComanda("Hanoi");
            Paste noodles = new Paste("Spicy Noodle", 25);
            hanoi.Add(noodles);
            Paste noodlesVegan = new Paste("Vegan Noodle", 30);
            hanoi.Add(noodlesVegan);
            SubComanda venetia = new SubComanda("Venetia");
            Pizza capriciosa = new Pizza("Capriciosa Mare", 32);
            venetia.Add(capriciosa);
            PriceStatistics priceStatistics = new PriceStatistics();
            hanoi.Print();
            venetia.Print();
            hanoi.Accept(priceStatistics);
            venetia.Accept(priceStatistics);
            priceStatistics.PrintPrice();

            Console.ReadLine();
        }
    }
}