using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Book
    {
        public string Title { get; set; }

        private Author Author { get; set; }
        private List<Chapter> Chapters = new List<Chapter>();

        public Book(string title)
        {
            Title = title;
        }

        public void addAuthor(Author author)
        {
            Author = author; 
        }

        public int CreateChapter(string chapterName)
        {
            var chapter = new Chapter(chapterName);
            Chapters.Add(chapter);
            return Chapters.IndexOf(chapter);
        }

        public Chapter GetChapter(int chapterIndex)
        {
            return Chapters[chapterIndex];
        }
    }
}
