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

        private List<Author> Authors = new List<Author>();

        public Book(string chapterName) : base(chapterName)
        {
            Name = chapterName;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
        public void AddContent(Element element)
        {
            base.Add(element);
        }


        public new void Print()
        {
            Console.WriteLine($"Book: {Name}");
            Console.WriteLine("Authors:");
            Authors.ForEach(author => author.Print());
            foreach (var element in elements)
            {
                element.Print();
            }
        }
    }
}
