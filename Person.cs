using System;

namespace ConsoleApplication
{
    public class Person
    {
        public string Firstname;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"My name Is {Firstname} {LastName}");
            
        }
    }
}
