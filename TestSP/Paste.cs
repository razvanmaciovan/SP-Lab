using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSP
{
    internal class Paste : IComanda
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Paste(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Paste {Name} costing {Price}");
        }

        public void Add(IComanda comanda)
        {
            throw new NotImplementedException();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPaste(this);
        }
    }
}
