using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Class.Delegates
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            Console.WriteLine($"path : {path}");

            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("saved");
        }
    }
}
