using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Class.Generics
{
    class AnimalGenerics<T> where T : Animal
    {
        public void Name(string name)
        {
            Console.WriteLine(name);
        }
    }
}
