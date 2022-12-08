using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    internal class DocumentManager
    {
        private static DocumentManager instance = null;
        public static DocumentManager Instance
        {
            get
            {
                if(instance is null)
                {
                    instance = new DocumentManager();
                }
                return instance;
            }
        }
        public Book Book { get; set; }

    }
}
