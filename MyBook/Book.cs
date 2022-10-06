using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Book
    {
        public string Name { get; set; }
        public List<string> paragraphs = new List<string>();
        public List<string> images = new List<string>();
        public List<string> tables = new List<string>();

        public Book(string name)
        {
            this.Name = name;
        }
        public void createNewParagraph(string text)
        {
            this.paragraphs.Add(text);
        }

        public void createNewImage(string text)
        {
            this.images.Add(text);
        }

        public void createNewTable(string text)
        {
            this.tables.Add(text);
        }

        public void print()
        {
            Console.WriteLine($"{this.Name} paragraphs: ");
            paragraphs.ForEach(paragraph => Console.WriteLine($"{paragraph}; "));
            Console.WriteLine($"{this.Name} images: ");
            images.ForEach(image => Console.WriteLine($"{image}; "));
            Console.WriteLine($"{this.Name} paragraphs: ");
            tables.ForEach(table => Console.WriteLine($"{table}; "));
        }
    }
}
