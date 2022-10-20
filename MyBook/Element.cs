using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public interface Element
    {
        void Print();
        void Add(Element element);
        void Remove(Element element);
        int Get(Element element);
    }
}
