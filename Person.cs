using System;

namespace ConsoleApplication
{
    public class Person
    {
        public string Name;
        public string Firstname;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"My name Is {Firstname} {LastName}");
            
        }

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, My Name Is {Name}");
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
}
