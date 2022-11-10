using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Table : IElement
    {
        public string Title { get; set; }
        public Table(string title)
        {
            Title = title;
        }

        public void Add(IElement element)
        {

        }

        public void Remove(IElement element)
        {

        }
        public int Get(IElement element)
        {
            return 0;
        }
        public void Print() => Console.WriteLine($"Table with Title: {Title}");

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTable(this);
        }
    }
}
