using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public interface IVisitor
    {
        void VisitBook(Book book);
        void VisitParagraph(Paragraph paragraph);
        void VisitSection(Section section);
        void VisitTable(Table table);
        void VisitImage(Image image);
        void VisitImageProxy(ImageProxy imageProxy);

    }
}
