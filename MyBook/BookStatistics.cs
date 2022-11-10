using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    internal class BookStatistics: IVisitor
    {
        public int BookCounter { get; set; }
        public int ImageCounter { get; set; }
        public int ParagraphCounter { get; set; }
        public int SectionCounter { get; set; }
        public int TableCounter { get; set; }

        public void VisitBook(Book book)
        {
            BookCounter++;
        }

        public void VisitImage(Image image)
        {
            ImageCounter++;
        }

        public void VisitImageProxy(ImageProxy imageProxy)
        {
            ImageCounter++;
        }

        public void VisitParagraph(Paragraph paragraph)
        {
            ParagraphCounter++;
        }

        public void VisitSection(Section section)
        {
            SectionCounter++;
        }

        public void VisitTable(Table table)
        {
            TableCounter++;
        }

        public void PrintStatistics()
        {
            if (ImageCounter > 0) Console.WriteLine($"*** Number of images: {ImageCounter}");
            if (TableCounter > 0) Console.WriteLine($"*** Number of tables: {TableCounter}");
            if (ParagraphCounter > 0) Console.WriteLine($"*** Number of paragraphs: {ParagraphCounter}");
            if (SectionCounter > 0) Console.WriteLine($"*** Number of sections: {SectionCounter}");
        }
    }
}
