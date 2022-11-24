using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSP
{
    internal class Pizza : IComanda
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Pizza(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Pizza {Name} costing {Price}");
        }

        public void Add(IComanda comanda)
        {
            throw new NotImplementedException();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPizza(this);
        }
    }
}
