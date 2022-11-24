using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestSP
{
    internal class SubComanda : IComanda
    {
        private List<IComanda> comenzi = new List<IComanda>();
        public string Name { get; set; }
        public SubComanda(string name)
        {
            Name = name;
        }
        public void Add(IComanda comanda)
        {
            comenzi.Add(comanda);
        }

        public void Print()
        {
            Console.WriteLine(Name);
            comenzi.ForEach(e => {
                if (e is not SubComanda) e.Print();
            });
        }

        public void Accept(IVisitor visitor)
        {
            comenzi.ForEach(e => {
                if (e is not SubComanda) e.Accept(visitor);
            });
        }
    }
}
