﻿using System;
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
            Author rpGheo = new Author("Radu Pavel Gheo");
            discoTitanic.addAuthor(rpGheo);
            int indexChapterOne = discoTitanic.CreateChapter("Capitolul 1");
            Chapter chp1 = discoTitanic.GetChapter(indexChapterOne);
            int indexSubChapterOneOne = chp1.CreateSubChapter("Subcapitol 1.1");
            SubChapter scOneOne = chp1.GetSubChapter(indexSubChapterOneOne);


            scOneOne.CreateNewParagraph("Paragraph 1");
            scOneOne.CreateNewParagraph("Paragraph 2");
            scOneOne.CreateNewParagraph("Paragraph 3");
            scOneOne.CreateNewImage("Image 1");
            scOneOne.CreateNewParagraph("Paragraph 4");
            scOneOne.CreateNewTable("Table 1");
            scOneOne.CreateNewParagraph("Paragraph 5");

            scOneOne.Print();
            Console.ReadLine();

        }
    }
}
