using System;

namespace ConsoleApplication.Class.Inheritance
{
    class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object Copied");
        }

        public void Paste()
        {
            Console.WriteLine("Object Pasted");
        }
    }
}
