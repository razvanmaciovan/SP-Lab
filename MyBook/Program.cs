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
            long startTime = CurrentTimeMillis();
            ImageProxy img1 = new ImageProxy("Pamela Anderson");
            ImageProxy img2 = new ImageProxy("Kim Kardashian");
            ImageProxy img3 = new ImageProxy("Kirby Griffin");
            Section playboyS1 = new Section("Front Cover");
            playboyS1.Add(img1);
            Section playboyS2 = new Section("Summer Girls");
            playboyS2.Add(img2);
            playboyS2.Add(img3);
            Book playboy = new Book("Playboy");

            playboy.AddContent(playboyS1);
            playboy.AddContent(playboyS2);
            long endTime = CurrentTimeMillis();
            Console.WriteLine("Creation of the content took " + (endTime -
            startTime) + " milliseconds");
            startTime = CurrentTimeMillis();
            playboyS1.Print();
            endTime = CurrentTimeMillis();
            Console.WriteLine("Printing of the section 1 took " + (endTime -
            startTime) + " milliseconds");
            startTime = CurrentTimeMillis();
            playboyS1.Print();
            endTime = CurrentTimeMillis();
            Console.WriteLine("Printing again the section 1 took " + (endTime -
            startTime) + " milliseconds");
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
