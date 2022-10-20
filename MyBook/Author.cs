using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Author
    {
        public string Name { get; set; }
        public Author(string authorName)
        {
            Name = authorName;
        }
        public void Print() => Console.WriteLine(Name);
    }
}
