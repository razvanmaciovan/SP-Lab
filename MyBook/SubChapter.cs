using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class SubChapter
    {
        private List<Paragraph> ParagraphsList = new List<Paragraph>();
        private List<Image> ImagesList = new List<Image>();
        private List<Table> TablesList = new List<Table>();
        public string Name { get; set; }

        public SubChapter(string subChapterName) => Name = subChapterName;
        public void CreateNewParagraph(string paragraphText) => ParagraphsList.Add(new Paragraph(paragraphText));

        public void CreateNewImage(string imageText) => ImagesList.Add(new Image(imageText));

        public void CreateNewTable(string tableText) => TablesList.Add(new Table(tableText));

        public void Print()
        {
            Console.WriteLine($"Subchapter: {Name} ");
            ParagraphsList.ForEach(paragraph => paragraph.Print());
            ImagesList.ForEach(image => image.Print());
            TablesList.ForEach(table => table.Print());
        }
    }
}
