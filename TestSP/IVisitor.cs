using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSP
{
    internal interface IVisitor
    {
        void VisitPizza(Pizza pizza);
        void VisitPaste(Paste paste);
        void VisitSalata(Salata salata);
    }
}
