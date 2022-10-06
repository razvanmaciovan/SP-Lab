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
        private List<string> paragraphsList = new List<string>();
        private List<string> imagesList = new List<string>();
        private List<string> tablesList = new List<string>();

        public Book(string name)
        {
            this.Name = name;
        }
        public void createNewParagraph(string paragraphText)
        {
            this.paragraphsList.Add(paragraphText);
        }

        public void createNewImage(string imageText)
        {
            this.imagesList.Add(imageText);
        }

        public void createNewTable(string tableText)
        {
            this.tablesList.Add(tableText);
        }

        public void print()
        {
            Console.WriteLine($"{this.Name} paragraphs: ");
            paragraphsList.ForEach(paragraph => Console.WriteLine($"{paragraph}; "));
            Console.WriteLine($"{this.Name} images: ");
            imagesList.ForEach(image => Console.WriteLine($"{image}; "));
            Console.WriteLine($"{this.Name} paragraphs: ");
            tablesList.ForEach(table => Console.WriteLine($"{table}; "));
        }
    }
}
