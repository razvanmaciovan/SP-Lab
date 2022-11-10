using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyBook
{
    public class Image : IElement, Picture
    {
        public string ImageName { get; set; }

        public string Url => throw new NotImplementedException();

        public int Dim => throw new NotImplementedException();

        public string Content => throw new NotImplementedException();

        public Image(string imageName)
        {
            ImageName = imageName;
            try
            {
                Thread.Sleep(5000);
            }
            catch (ThreadInterruptedException)
            {
                throw;
            }
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

        public void Print() => Console.WriteLine($"Image with name: {ImageName}");

        public void Accept(IVisitor visitor)
        {
            visitor.VisitImage(this);
        }
    }
}
