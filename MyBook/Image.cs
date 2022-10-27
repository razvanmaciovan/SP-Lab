using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyBook
{
    public class Image : Element
    {
        public string ImageName { get; set; }
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

        public void Add(Element element)
        {

        }

        public void Remove(Element element)
        {

        }
        public int Get(Element element)
        {
            return 0;
        }

        public void Print() => Console.WriteLine($"Image with name: {ImageName}");
    }
}
