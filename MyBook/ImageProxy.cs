using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class ImageProxy : IElement, Picture
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
        public void Add(IElement element)
        {
            throw new NotImplementedException();
        }

        public int Get(IElement element)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            LoadImage().Print();
        }

        public void Remove(IElement element)
        {
            throw new NotImplementedException();
        }

        public void Accept(IVisitor visitor)
        {
           visitor.VisitImageProxy(this);
        }
    }
}
