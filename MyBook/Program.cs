using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Section cap1 = new Section("Capitolul 1");
            Paragraph p1 = new Paragraph("Paragraph 1");
            cap1.Add(p1);
            Paragraph p2 = new Paragraph("Paragraph 2");
            cap1.Add(p2);
            Paragraph p3 = new Paragraph("Paragraph 3");
            cap1.Add(p3);
            Paragraph p4 = new Paragraph("Paragraph 4");
            cap1.Add(p4);
            Console.WriteLine("Printing without Alignment");
            Console.WriteLine();
            cap1.Print();
            p1.setAlignStrategy(new AlignCenter());
            p2.setAlignStrategy(new AlignRight());
            p3.setAlignStrategy(new AlignLeft());
            Console.WriteLine("Printing with Alignment");
            Console.WriteLine();
            cap1.Print();
            Console.ReadLine();

        }

        //N-am gasit echivalentul din java, e un necessary evil codul de mai jos
        //TODO Util class

        private static readonly DateTime begin = new DateTime
    (1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - begin).TotalMilliseconds;
        }
    }
}
