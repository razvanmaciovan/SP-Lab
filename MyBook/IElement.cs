using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public interface IElement
    {
        void Print();
        void Add(IElement element);
        void Remove(IElement element);
        int Get(IElement element);
        void Accept(IVisitor visitor);
    }
}
