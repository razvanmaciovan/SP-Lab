using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public interface IAlignStrategy
    {
        void Render(string paragraphText);
        void Print();
    }
}
