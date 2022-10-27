using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Section : Element
    {
        public string Title { get; set; }
        public static List<Element> elements = new List<Element>();

        public Section(string chapterName)
        {
            Title = chapterName;
        }

        public void Add(Element element)
        {
            elements.Add(element);
        }
        public void Remove(Element element)
        {

        }
        public int Get(Element element)
        {
            return 0;
        }

        public void Print()
        {
            Console.WriteLine(Title);
            elements.ForEach(e =>{
                if (!(e is Section)) e.Print();
            });
        }

    }
}
