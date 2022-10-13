using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Table
    {
        public string Title { get; set; }
        public Table(string title)
        {
            Title = title;
        }
        public void Print() => Console.WriteLine($"Table with Title: {Title}");
    }
}
