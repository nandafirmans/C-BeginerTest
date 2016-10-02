using System;

namespace ConsoleApplication.Class.Inheritance
{
    class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine($"the {url} is added");
        }
    }
}
