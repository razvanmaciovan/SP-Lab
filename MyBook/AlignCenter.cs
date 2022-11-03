using System;

namespace MyBook
{
    public class AlignCenter : IAlignStrategy
    {
        private readonly string CustomText = "~~~";
        public string RenderedText { get; set; }
        public void Print() => Console.WriteLine($"Paragraph: {RenderedText}");

        public void Render(string paragraphText)
        {
            RenderedText = CustomText + paragraphText + CustomText;
        }
    }
}