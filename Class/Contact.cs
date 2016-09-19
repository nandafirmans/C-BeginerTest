using System.Collections.Generic;

namespace ConsoleApplication.Class
{
    public class Contact
    {
        public string Name;
        public int Id;

        /*when the object of this class is created, 
         this List<> should be declared as an empty List<> of an object, 
         if not the application will crash*/
        public List<Order> Orders;


        /* I direcly create a readonly object of calculator List<> on the field for preventing compile error, 
        instead of declare it on the constructor*/
        public readonly List<Calculator> Calc = new List<Calculator>();


        public Contact()  // <== This is a Constructor ( a method is called when an instance of a class is created )
        {
            /* its declared as an empty list when the class is created,
            if this contructor is called */
            this.Orders = new List<Order>();
        }


        /* This is a Constructor ( a method is called when an instance of a class is created ) 
        in case this have a parameter(id) to fill */
        public Contact(int id)
            
            /*when this constructor is called, 
            this line willbe executed,
            and call the first constructor with parameter less (line 11)*/
            : this() 
        {
            this.Id = id;
        }


        /* This is a Constructor ( a method is called when an instance of a class is created ) 
        in case this I have a parameter(string, id) to fill */
        public Contact(string name, int id)
            
            /* when this constructor is called, 
              "this(id)" line will be executed 
              and call the second constructor with this "id" parameter (line 16) */
            : this(id) 
        {
            this.Name = name;
        }


        public void Test()
        {
            //Calc = new List<Calculator>(); // its better rewatch C# Intermediate by Mosh hamedani (010 - Fields)
        }
    }

}
