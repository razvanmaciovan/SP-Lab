using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    public class Chapter
    {
        List<SubChapter> SubChapters = new List<SubChapter>();
        public string Name { get; set; }

        public Chapter(string chapterName)
        {
            Name = chapterName;
        }

        public int CreateSubChapter(string subChapterName)
        {
            var subChapter = new SubChapter(subChapterName);
            SubChapters.Add(subChapter);
            return SubChapters.IndexOf(subChapter);
        }

        public SubChapter GetSubChapter(int indexOfSubChapter)
        {
            return SubChapters[indexOfSubChapter];
        }

    }
}
