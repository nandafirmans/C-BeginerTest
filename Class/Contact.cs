using System.Collections.Generic;

namespace ConsoleApplication.Class
{
    public class Contact
    {
        public string Name;
        public int Id;
        public List<Order> Orders; // when the object of this class is created, this List<> should be declared as an empty List<> of an object, if not the application will crash

        public Contact()  // <== This is a Constructor ( a method is called when an instance of a class is created )
        {
            this.Orders = new List<Order>(); // its declared as an empty list when the class is created, if this contructor is called 
        }

        public Contact(int id) // <== This is a Constructor ( a method is called when an instance of a class is created ) in case this have a parameter(id) to fill
            : this() // when this constructor is called, this line willbe execute and call the first constructor with parameter less (line 11)
        {
            this.Id = id;
        }

        public Contact(string name, int id) // <== This is a Constructor ( a method is called when an instance of a class is created ) in case this have a parameter(string, id) to fill
            : this(id) // when this constructor is called, this line willbe execute and call the second constructor with takin id parameter (line 16)
        {
            this.Name = name;
        }
    }


}
