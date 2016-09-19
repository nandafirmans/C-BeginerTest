using System;

namespace ConsoleApplication
{
    public class Person
    {
        public string Name;
        public string Firstname;
        public string LastName;
        public int Age;
        private DateTime _birthDate;


        /*This Is an Auto Implemented Property.
         when C# compiler see this. Internally, it will create Fields and Method "get() and set()" for us. 
         So we dont have to create private _fields and Method Getter & Setter.
         
        for more info, please do this :

            > look up into = ( bin/debug/nameOfProject.exe ) 
            > open console using "Shift + Click"
            > on the console type = "ildasm nameOfProject.exe" 
            > it will open a IL DASM (Intermediate Language Disassembler) window 
            > open theclass and you will see the compiler create method and fields for BirthDay Property*/
        public DateTime BirthDate { get; set; }

        public int AgeProperty
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days/365;

                return years;
            } 
        }

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

        public string SetBirthDateTime(string dateTimeBirth)
        {

            try
            {
                if (!string.IsNullOrEmpty(dateTimeBirth))
                {
                    var birthDate = this._birthDate = Convert.ToDateTime(dateTimeBirth);

                    return birthDate.ToString();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected Error Ocurred");                
            }

            return "Wrong Format Parameter";
        }

        public DateTime GetBirthDateTime()
        {
            return this._birthDate;
        }
    }
}