using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    internal interface Picture
    {
        string Url { get; }
        int Dim { get; }
        string Content { get; }
    }
}
