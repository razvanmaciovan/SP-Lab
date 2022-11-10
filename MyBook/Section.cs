using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Section : IElement
    {
        public string Title { get; set; }
        public static List<IElement> elements = new List<IElement>();

        public Section(string chapterName)
        {
            Title = chapterName;
        }

        public void Add(IElement element)
        {
            elements.Add(element);
        }
        public void Remove(IElement element)
        {

        }
        public int Get(IElement element)
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

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSection(this);
            elements.ForEach(e => {
                if (!(e is Section)) e.Accept(visitor);
            });
        }
    }
}
