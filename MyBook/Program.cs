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
            Book discoTitanic = new Book("Disco Titanic");
            discoTitanic.createNewParagraph("Paragraph 1");
            discoTitanic.createNewParagraph("Paragraph 2");
            discoTitanic.createNewParagraph("Paragraph 3");
            discoTitanic.createNewImage("Image 1");
            discoTitanic.createNewParagraph("Paragraph 4");
            discoTitanic.createNewTable("Table 1");
            discoTitanic.createNewParagraph("Paragraph 5");

            discoTitanic.print();
            Console.ReadLine();

        }
    }
}
