using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class ImageProxy : Element, Picture
    {
        public string Url { get; set; }

        public Image RealImage { get; set; }

        public int Dim => throw new NotImplementedException();

        public string Content => throw new NotImplementedException();

        public ImageProxy(string url)
        {
            Url = url;
        }

        public Image LoadImage()
        {
            if (RealImage == null)
            {
                RealImage = new Image(Url);
            }

            return RealImage;
        }
        public void Add(Element element)
        {
            throw new NotImplementedException();
        }

        public int Get(Element element)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            LoadImage().Print();
        }

        public void Remove(Element element)
        {
            throw new NotImplementedException();
        }
    }
}
