using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyBook
{
    public class AlignRight : IAlignStrategy
    {
        private readonly string CustomText = "\t\t";
        public string RenderedText { get; set; }
        public void Print() => Console.WriteLine($"Paragraph: {RenderedText}");

        public void Render(string paragraphText)
        {
            RenderedText = CustomText + paragraphText;
        }
    }
}
