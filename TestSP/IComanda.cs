using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestSP
{
    internal interface IComanda
    {
        void Add(IComanda comanda);
        void Print();
        void Accept(IVisitor visitor);

    }
}
