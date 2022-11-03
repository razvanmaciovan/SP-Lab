using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public static class ImageLoaderFactory
    {
        public static void Create(string path)
        {
            IImageLoader imageLoader = null;
            imageLoader.Load(path);
        }
    }
}
