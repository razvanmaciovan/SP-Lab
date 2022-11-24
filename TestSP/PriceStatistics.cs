using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSP
{
    internal class PriceStatistics : IVisitor
    {
        public int PizzaPrice { get; set; }
        public int PastePrice { get; set; }
        public int SalataPrice { get; set; }

        public void VisitPizza(Pizza pizza)
        {
            PizzaPrice += pizza.Price;
        }

        public void VisitPaste(Paste paste)
        {
            PastePrice += paste.Price;
        }

        public void VisitSalata(Salata salata)
        {
            SalataPrice += salata.Price;
        }

        public void PrintPrice()
        {
            var totalPrice = PizzaPrice + PastePrice + SalataPrice;
            Console.WriteLine($"Total Price for Pizza is {PizzaPrice}");
            Console.WriteLine($"Total Price for Paste is {PastePrice}");
            Console.WriteLine($"Total Price for Salata is {SalataPrice}");
            Console.WriteLine($"Total Price for order is {totalPrice}");
        }
    }
}
