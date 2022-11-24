using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSP
{
    internal class Salata : IComanda
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Salata(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Salata {Name} costing {Price}");
        }

        public void Add(IComanda comanda)
        {
            throw new NotImplementedException();
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitSalata(this);
        }
    }
}
