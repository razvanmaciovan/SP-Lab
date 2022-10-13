using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Image
    {
        public string ImageName { get; set; }
        public Image(string imageName)
        {
            ImageName = imageName;
        }

        public void Print() => Console.WriteLine($"Image with name: {ImageName}");
    }
}
