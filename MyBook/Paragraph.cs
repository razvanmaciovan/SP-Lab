using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Paragraph
    {
        public string Text { get; set; }
        public Paragraph(string text)
        {
            Text = text;
        }
        public void Print() => Console.WriteLine($"Paragraph: {Text}");
    }
}
