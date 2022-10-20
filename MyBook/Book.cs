using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Book : Section
    {
        public string Name { get; set; }

        private Author Author { get; set; }
        private List<Element> Sections = new List<Element>();

        public Book(string chapterName) : base(chapterName)
        {
            Name = chapterName;
        }

        public void AddAuthor(Author author)
        {
            Author = author; 
        }
        public void AddContent(Element element)
        {
            Sections.Add(element);
        }

        public new void Print()
        {
            Console.WriteLine($"Book: {Name}");
            Author.Print();
            base.Print();
        }
    }
}
