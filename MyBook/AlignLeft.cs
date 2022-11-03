using System;

namespace MyBook
{
    public class AlignLeft : IAlignStrategy
    {
        private readonly string CustomText = "####";
        public string RenderedText { get; set; }
        public void Print() => Console.WriteLine($"Paragraph: {RenderedText}");

        public void Render(string paragraphText)
        {
            RenderedText = paragraphText + CustomText;
        }
    }
}