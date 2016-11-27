using ConsoleApplication.Class;
using ConsoleApplication.Class.Composition;
using ConsoleApplication.Class.ConstructorAndInheritance;
using ConsoleApplication.Class.Inheritance;
using ConsoleApplication.Class.UpCastingDownCasting;
using ConsoleApplication.Class.InterfaceExtensibility;
using ConsoleApplication.Class.Generics;
using ConsoleApplication.Enumerator;
using ConsoleApplication.Class.Delegates;
using ConsoleApplication.Class.ExtensionMethod;
using ConsoleApplication.Class.LINQ;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

            #region collapse 
            //program._Class();
            //program._ArrayBasic();
            //program._String();
            //program._Enumeration(3);
            //program._ValueAndReferenceTypes();
            //program._Iteration();
            //program._RandomClass();
            //program._Array();
            //program._GenericList();
            //program._DateTime();
            //program._TimeSpan();
            //program._StringAdvance();
            //program._StringBuilder();
            //program._ProceduralPrograming();
            //program._FileAndFileInfo();
            //program._DirectoryAndDirectoryInfo();
            //program._Path();
            #endregion

            //program._ClassIntermediate();
            //program._ClassConstructor();
            //program._Method();
            //program._AccessModifiers();
            //program._Properties();
            //program._Indexer();
            //program._Inheritance();
            //program._Composition();
            //program._ConstructorAndInheritance();
            //program.UpCastingDownCasting();
            //program.InterfaceExtensibility();
            //program.Generics();
            //program.Delegates();
            //program.LambdaExpression();
            //program.ExtensionMethod();
            //program.LINQ();
            //program.NullableType();



            Console.ReadLine();
        }

        #region collapse

        private void _Class()
        {
            var result = Calculator.Add(2, 4); //using static method ( Dont Need Declare an object )

            var agus = new Person
            {
                Firstname = "agus",
                LastName = "bagus"
            }; //Declare Created an object ' "new" syntax use to assign place for an object in memory'

            agus.Introduce(); // not using static method (have to create an object first)

            Console.WriteLine(result);
        }

        private void _ArrayBasic()
        {
            var arrInt = new int[3];
            var arrBool = new bool[3];

            arrInt[0] = 1;
            arrBool[0] = true;


            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrBool[i]);
            }

            Console.WriteLine(string.Join(", " , arrInt)); // JURUS BARU
            
        }

        private void _String()
        {
            string str = "some String";
            var indexStr = new char[4] { str[5], str[1], str[2], str[0] }; // JURUS BARU

            string path = @"John Please Look at the path >  
                                C:\some\path
                                    and
                                D:\some\path
                            "; // JURUS BARU (VERBATIM STRING)

            Console.WriteLine($" {path} /n {indexStr} ");
        }

        private void _Enumeration(int id)
        {
            var methodName = Function.Shipment( Convert.ToString((ShippingEnum)id) ); // send integer from parameter  and get return as a string

            var objectEnum = Enum.Parse(typeof(ShippingEnum), methodName); // use return from 'Function.Shipment' and cast it into an enum as an object

            var realEnum = (ShippingEnum)objectEnum; // convert object enum to an 'enum'

            var methodId = (int)realEnum; //get value from and realenum and cast it to an integer

            Console.WriteLine( Convert.ToString($"Shipping Name : {methodName} , Shipping ID : {methodId}") ); // JURUS BARU (STRING INTERPOLATION)
        }

        private void _ValueAndReferenceTypes()
        {
            int num = 1; // VALUE TYPE
            Person person = new Person() {Age = 30}; // REFRENCE TYPE

            int a = 10; // 'value type' the actual value will not change even the coppied value have changed,
            int b = a;  //  the actual variable stored on the stack memory and the coppied value create new location with new same value on the stack memory 
            b++;

            int[] arr1 = new int[3] {1,2,3}; // 'refrence type' cause array is a class on dotNet so the actual value will be change if the coppied value have changed
            int[] arr2 = arr1;               // the variable is create location with value on Heap memory, then the variable stored on the stack memory. the variable will be pointing its value to the heap,
            arr2[0] = 99;                    // if the variable coppied. the current coppied variable will pointing its value, same as with the refrence variable on the heap memory

            Function.Increment(num);
            Function.MakeOld(person);

            Console.WriteLine($"Value Type : {num} , Refrence Type : {person.Age}");
        }

        private void _Iteration()
        {
            while (true) // Continue Looping if the condition is true
            {
                Console.Write("Type Your name here : ");
                string name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine($"Echo : {name}");

                    continue; // Start loop from the top "in case 'while' loop"
                }

                break; // Jump out of the loop 
            }
        }

        private void _RandomClass()
        {
            const int length = 10;
            var rand = new Random(); // create random class
            var buffer = new char[length]; // create array of char

            for (int i = 0; i < length; i++)
            {
                buffer[i] = (char)('a' + rand.Next(0, 26)); // create random number and cast it to char, then store it to an array of char 
            }

            var password = new string(buffer); // build new string then store the array of char into it

            Console.Write(password);

            //Console.WriteLine((int)'a'); //Cast char to int and the result is '97 ( in ascii is "a" more info at http://ascii-code.com)' 
        }

        private void _Array()
        {
            var number = new int[] {5, 9, 12, 3, 1, 7};

            //Length
            Console.WriteLine("Result of Legth");
            Console.WriteLine(number.Length); // Length method counting the length of an array 

            //IndexOF   
            var index = System.Array.IndexOf(number, 1); //search index of the value in array
            Console.WriteLine("Result of IndexOf() method");
            Console.WriteLine($"Index of 1 in array is : {index}");

            //Clear
            System.Array.Clear(number, 0, 2); // clear value inside an array ' in case integer so the value should be 0 (if its a string or an object it should be null)' 
            Console.WriteLine("Result of Clear() method");

            foreach (var num in number)
            {
                Console.WriteLine(num);
            }

            //Copy 
            var pasteArray = new int[3];
            System.Array.Copy(number, pasteArray, 3); // copying a value of a targeted array to new array
            Console.WriteLine("Result of Copy() method");

            foreach (var item in pasteArray)
            {
                Console.WriteLine(item);
            }

            //Sort
            System.Array.Sort(number);
            Console.WriteLine("Result of Sort() method");

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
        }

        private void _GenericList()
        {
            var numbers = new List<int>() {1, 2, 3, 4};

            //Add()
            numbers.Add(1); // add value on the list

            //AddRange() 
            numbers.AddRange(new []{ 7, 8, 9}); // adding array or list on the current list 

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //IndexOf()
            Console.WriteLine($"Index of 1 : {numbers.IndexOf(1)}"); // search selected value on the list and return the current index

            //LastIndexOf()
            Console.WriteLine($"Last Index of 1 : {numbers.LastIndexOf(1)}"); // search selected value on the list 'reversed'

            //Count()
            Console.WriteLine($"Count numbers List<T> : {numbers.Count}"); // counting all value on the list, and returning a number of the list length

            //Remove()
            Console.WriteLine("remove all 1 using Remove() method :");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(1); //remove selected value on the list
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Clear()
            numbers.Clear(); //clear all value on the list

            Console.WriteLine($"after Clear() method, numbers.Count = {numbers.Count}");
        }

        private void _DateTime()
        {
            var dateTime = new DateTime();
            var now = DateTime.Now;

            Console.WriteLine($"Hour : {now.Hour}");
            Console.WriteLine($"Minute : {now.Minute}");

            var tommorow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine($"Tommorow : { tommorow.ToLongDateString() } || Yesterday : { yesterday.ToLongDateString() }");

            Console.WriteLine();

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToString("dd-MM-yyyy HH:mm"));
        }

        private void _TimeSpan()
        {
            //Creating
            var timeSpan = new TimeSpan(1, 2, 3); //1 : Hours, 2 : Minutes, 3 : Second

            var timeSpan1 = new TimeSpan(1, 0, 0); // (create an object) create 1 Hours TimeSpan
            var timeSpan2 = TimeSpan.FromHours(1); // create 1 Hours TimeSpan, But more readable using this way than 'timespan1' way

            var start = DateTime.Now;
            var finish = DateTime.Now.AddMinutes(4);
            var duration = finish - start;
            Console.WriteLine($"Duration : {duration}"); // represent a TimeSpan

            // Properties
            Console.WriteLine($"Minutes : { timeSpan.Minutes }");
            Console.WriteLine($"Total Minutes : { timeSpan.TotalMinutes }");

            //Add
            Console.WriteLine($"Add Example : { timeSpan.Add(TimeSpan.FromMinutes(8)) }");
            Console.WriteLine($"Subtract Example : { timeSpan.Subtract(TimeSpan.FromMinutes(2.03)) }");

            //Parse
            Console.WriteLine($"Parsing String to a TimeSpan : { TimeSpan.Parse("02:50") }"); // Converting String to become TimeSpan Object
        }

        private void _StringAdvance()
        {
            /* String, Array, List */

            var fullName = "Nanda Firmansyah";
            Console.WriteLine($"Trim : { fullName.Trim() }");
            Console.WriteLine($"ToUpper : { fullName.Trim().ToUpper() }");

            var index = fullName.IndexOf(' '); // get the current index of given value, return it as an integer
            var firstName = fullName.Substring(0, index); // selected the length of an index from a string
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine($"FirsName : { firstName }");
            Console.WriteLine($"LastName : { lastName }");

            var splitToArray = fullName.Split(' '); // Split string to and return it as an array of string, depend by index of given value 
            Console.WriteLine($"FullName using split method : { splitToArray[0] } { splitToArray[1] }");

            Console.WriteLine($"Replace() method : { fullName.Replace("Firmansyah", "firmans").Replace(" ", string.Empty) }"); // selected current string value and replace it by the given value on the second parameter

            if (String.IsNullOrWhiteSpace("")) //Return Boolean
            {
                Console.WriteLine("invalid");
            }

            var numbers = "1234";
            Convert.ToInt32(numbers); // convert string to int

            float price = 19.56f; 
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));

            Console.WriteLine();

            var sentence = "This is going to be a really really really really really really really long text";
            var sentenceSummarized = Function.SummarizingText(sentence);
        }

        private void _StringBuilder()
        {
            var builder = new StringBuilder();

            builder
                .Append('-', 10) 
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace("-", "+")
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
        }

        private void _ProceduralPrograming()
        {
            Console.WriteLine("Whats Your Name : ");
            var name = Console.ReadLine();

            Console.WriteLine($"Reversed Name : { Function.ReverseName(name) }");
        }

        private void _FileAndFileInfo()
        {

            //Operating system Does a lot of security checking with File() Class
            var path = @"D:\test.txt";

            File.Delete(path);
            File.Copy(@"D:\Logs\test.txt", path, true);

            if (File.Exists(path))
            {
                Console.WriteLine("File Is Exist");
            }

            Console.WriteLine(File.ReadAllText(path));


            // Operating System not much doing the security cheking with FileInfo() Object
            var fileinfo = new FileInfo(path);

            if (!Directory.Exists(@"D:\pathTest"))
            {
                Directory.CreateDirectory(@"D:\pathTest");
            }

            fileinfo.CopyTo(@"D:\pathTest\test.txt");
        }

        private void _DirectoryAndDirectoryInfo()
        {
            //same as File() and FileInfo(), but this if for folder(Directory) :D
            Directory.CreateDirectory(@"D:\CreateDir");
            var files = Directory.GetFiles(@"D:\Nanda\Test\angular", "*.jpg*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"D:\Nanda\Test\angular", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }


            DirectoryInfo directoryInfo = new DirectoryInfo("../path");

            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }

        private void _Path()
        {
            var path1 = @"C:\Users\nanda\Downloads\main.png";

            var dotIndex = path1.IndexOf('.');
            var extension = path1.Substring(dotIndex); //get the extension using string static method 

            Console.WriteLine(extension);


            //Using System.IO.Path
            Console.WriteLine($"Extetension : {Path.GetExtension(path1)}");
            Console.WriteLine($"FileName : {Path.GetFileName(path1)}");
            Console.WriteLine($"FileName without extension: {Path.GetFileNameWithoutExtension(path1)}");
            Console.WriteLine($"Directory Name: {Path.GetDirectoryName(path1)}");
        }

        #endregion

        private void _ClassIntermediate()
        {
            /*
             CLASSES :
             * Classes are building blocks of software applications. 
             * A class encapsulates data (stored in ﬁelds) and behaviour (deﬁned by methods)
             * An object is an instance of a class. We can create an object using the new operator. */

            var person = new Person();
            person.Name = "John"; // using object to call a method
            person.Introduce("Nanda");

            var p = Person.Parse("Jancok"); // using static method, Parse method is returning a Person() Object, I dont have to create an object first
            p.Introduce("Nanda");

        }

        private void _ClassConstructor()
        {
            /*
             Constructors : 
                * A constructor is a method that is called when an instance of a class is created. 
                * We use constructors to put an object in an early state.
                * As a best practice, deﬁne a constructor only when an object “needs” to be initialised or it won’t be able to do its job. 
                * Constructors do not have a return type, not even void, and they should have the exact same name as the class.
             */

            var customer = new Contact("John", 1);
            Console.WriteLine($"id = {customer.Id} name = {customer.Name}");
        }

        private void _Method()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(200, 100));
                point.Move(13, 16);

                Console.WriteLine($" x = { point.X } y = { point.Y }");
            }
            catch (Exception)
            {
                Console.WriteLine("an unexpected error is occured");
            }


            Console.WriteLine("-------------------------------------------------");

            var calculator = new Calculator();

            /* actually the Add() method accepted the Array of an Integer, 
            but I dont have to pass something like this( new int[]{1,2,3,4} ), 
            because on the Add() method I've been already using "params" to calling this method more simple */
            var add1 = calculator.Add(1, 2, 3, 4, 5);
            var add2 = calculator.Add(new int[] {1, 2, 3, 4, 5, 6}); // <== but if you wanna calling like this its Okay

            Console.WriteLine($"result of add(params int[] numbers = { add1 } and { add2 })");

            Console.WriteLine("-------------------------------------------------");

            try
            {
                var num = int.Parse("qwerty");
            }
            catch (Exception)
            {
                Console.WriteLine("Convertion Failed");
            }

            int number = 0;

            /* mosh told me to not use "out" modifier, because its little bit weird ._. 
            but some of the dotnet framework using "out" modifier, so maybe sometime I might use it */
            var tryParse = int.TryParse("qwerty", out number); 

            var result = tryParse ? number.ToString() : "conversion failed";

            Console.WriteLine(result);
        }

        private void _AccessModifiers()
        {
            var person = new Person();

            /* using getter and setter method,
            for get and set the Private method _birthDateTime on the Person() Class, 
            this is the part of encapsulaton ( object oriented programing ).

            Why ??? 
            Because Object is about behaviour, about what they do, 
            they Fields is primarly their internal,
            and their implementation details witch should be hidden from the outside world, 
            so the other class/object should not knowing about they fields */

            person.SetBirthDateTime("01 03 1995");
            var getBirth = person.GetBirthDateTime();

            Console.WriteLine($"birth = { getBirth }");
        }

        private void _Properties()
        {

            /*
             Property : 
             * A property is a kind of class member that is used for providing access to ﬁelds of a class.
             * As a best practice, we must declare ﬁelds as private and create public properties to provide access to them.
             * A property encapsulates a get and a set method 
             * Inside the get/set methods we can have some logic.
             * If you don’t need to write any speciﬁc logic in the get or set method, 
               it’s more efﬁcient to create an auto-implemented property. 
               An auto-implemented property encapsulates a private ﬁeld behind the scene. 
               So you don’t need to manually create one. The compiler creates one for you
            */

            var person = new Person();
            person.BirthDate = new DateTime(1995, 03, 06); // set the birthdate;
            int ages = person.AgeProperty; // the ageProperty will return an int (calculate the current year with the BirthDate) 

            Console.WriteLine($"person Ages { ages }");
        }

        private void _Indexer()
        {
            /*
             Indexers :
             * Indexer is a special kind of property that allows accessing elements of a list by an index. 
             * If a class has the semantics of a list, or collection, we can deﬁne an indexer property for it. 
               This way it’s easier to get or set items in the collection. */

            var cookie = new HttpCookie();

            cookie["name"] = "Nanda";
            Console.WriteLine(cookie["name"]);
        }

        //Class Coupling =============================================================================================== 
        #region Class Coupling

        /* 
        Class Coupling 
            * A measure of how interconnected classes and subsystems are. 
            * The more coupled classes, the harder it is to change them. 
            * A change in one class may affect many other classes. 
            * Loosely coupled software, as opposed to tightly coupled software, is easier to change. 
            * Two types of relationships between classes: "Inheritance" and "Composition" 

        Favour Composition over Inheritance :

            * Problems with inheritance: 
                • Easily abused by amateur designers / developers 
                • Leads to large complex hierarchies 
                • Such hierarchies are very fragile and a change may affect many classes 
                • Results in tight coupling 

            * Beneﬁts of composition: 
                • Flexible 
                • Leads to loose coupling 

            * Having said all that, it doesn’t mean inheritance should be avoided at all times. 
                In fact, it’s great to use inheritance when dealing with very stable classes on top of small hierarchies. 
                As the hierarchy grows (or variations of classes increase), the hierarchy, however, becomes fragile. 
                And that’s where composition can give you a better design (Mosh Hamedani)
        */

        private void _Inheritance()
            {
                /*
                    Inheritance :
                    * A kind of relationship between two classes that allows one to inherit code from the other. 
                    * Referred to as Is-A relationship: A Car is a Vehicle 
                    * Beneﬁts: code re-use and polymorphic behaviour. 
                */

                // so the "text object" is have the Copy() method, which the originally Copy() method is in the "Presentation Class"
                // because the "Text class" inherited "Presentation Class" so the "text object" can have all their method and properties

                var text = new Text();
        
                text.Width = 200;
                text.Copy();
            }

            private void _Composition()
            {
                /*
                    Composition :
                    * A kind of relationship that allows one class to contain another.
                */

                // We re-use the code in the logger class without 
                // the need to repeat that logic in DbMigrator and Installer

                var logger = new Logger();
                var installer = new Installer(logger);
                var dbMigrator = new DbMigrator(logger);
        
                installer.Installing();
                dbMigrator.Migrating();
            }
        #endregion
        //End Class Coupling ===========================================================================================

        private void _ConstructorAndInheritance()
        {

            /*
             Constructors and Inheritance :
                 * Constructors are not inherited and need to explicitly deﬁned in derived class. 
                 * When creating an object of a type that is part of an inheritance hierarchy, base class constructors are always executed ﬁrst. 
                 * We can use the base keyword to pass control to a base class constructor. 
             */

            var car = new Car("asdasd123");
        }

        private void UpCastingDownCasting()
        {
            /*
                 * Upcasting: conversion from a derived class to a base class 
                 * Downcasting: conversion from a base class to a derived class 
                 * All objects can be implicitly converted to a base class reference
             */

            Text2 text = new Text2();
            //Shape2 shape = new Shape2();

            Shape2 shape = text; // UpCasting the shape object cannot access property on the text class
            Shape2 shapee = (Text2) shape; // Downcasting the shape object can access property on the text class

            Console.WriteLine($"{ text.Width } + { shape.Width }");

        }


        private void InterfaceExtensibility()
        {
            /* INTERFACES : 
                *  An interface is a language construct that is similar to a class (in terms of syntax) but is fundamentally different. 
                *  An interface is simply a declaration of the capabilities (or services) that a class should provide.
                *  So an interface is purely a declaration. Members of an interface do not have implementation. 
                *  An interface can only declare methods and properties, but not ﬁelds (because ﬁelds are about implementation detail). 
                *  Members of an interface do not have access modiﬁers. 
                *  Interfaces help building loosely coupled applications. 
                   We reduce the coupling between two classes by putting an interface between them. 
                   This way, if one of these classes changes, 
                   it will have no impact on the class that is dependent on that (as long as the interface is kept the same).
                *  We can use interfaces to change our application’s behaviour by “extending” its code (rather than changing the existing code).
                *  
             */


            // in the constructor we passing the real class that implement the interfaces for doing the real logic
            // noted that interfaces doesn't do the real logic, that just make an application loosely tight, which is very powerfull 
            var DbMigrator = new DBMigrator(new ConsoleLogger());
            DbMigrator.Migrate();

            var DbMigrator2 = new DBMigrator(new FileLogger("C:\\Test\\Log.txt"));
            DbMigrator2.Migrate();
        }

        private void Generics()
        {
            /*
                Generics introduce to the .NET Framework the concept of type parameters, 
                which make it possible to design classes and methods that defer- 
                the specification of one or more types until the class or method is declared and instantiated by client code.
             */

            var cow = new AnimalGenerics<Cow>(); // Fill the generics with the real class

            var number = new NullableGenerics<int>(33); // Fill the generics with the real value in case should using value type (struct) not refrence type (class)

            Console.WriteLine("Has value ? " + number.HasValue); 
            Console.WriteLine("Value : " + number.GetValueOrDefault());
        }

        private void Delegates()
        {
            /*
             * DELEGATES :
                * is object that know how to call a method (or group of method)
                * is refrence to a function (or pointer to a function) 
             */
            var photoProcessor = new PhotoProcessor();
            var filter = new FilterHandler();

            PhotoProcessor.PhotoFilterHandler delegatedFilter = filter.ApplyContrast;
            delegatedFilter += filter.ApplyBrightness;
            delegatedFilter += filter.Resize;

            photoProcessor.Process("images.jpg", delegatedFilter);
        }

        private void LambdaExpression()
        {
            /*
                LAMBDA EXPRESSION : is Anonymous method (no access modifier, no name, no return statement)
            */

            Func<int, int> multiplier = number => number * number;

            Console.WriteLine(multiplier(6));
        }

        private void ExtensionMethod()
        {
            /*
                EXTENSION METHODS : 
                    * Allow us to change an existing class without : 
                        * change its source codes or creating another class that inherit from it
            */

            string post = "This is supposed to be a very long post blog blah blah blah...";
            string shorterPost = post.Shorter(5); // Shorter was a extension method of string

            Console.WriteLine(shorterPost);
        }

        private void LINQ()
        {
            /*
                LINQ ( LANGUAGE INTEGRATED QUERY ) :
                    * Gives you the capabillity to query an objects

            */

            var books = new BookRepository().GetBook();

            // LINQ example
            var cheapBooks = books
                                .Where(b => b.Price < 9000)
                                .OrderBy(b => b.Price);

            // another way to use LINQ
            var anotherCheapBooks = 
                from b in books
                where b.Price < 9000
                orderby b.Price
                select b;

            // notes!! actualy if you using "anotherCheapBooks" way.. behind the scene its gonna converted to "cheapBooks" way

            foreach (var b in anotherCheapBooks)
            {
                Console.WriteLine($"title :  { b.Title }");
                Console.WriteLine($"price : { b.Price }");
            }

            // HERE USEFULL LINQ METHODS:

                //books.Where();            // to return a filter list of book that match given condition
                //books.Single();           // to return a single book that match given condition will throw an error if condition false
                //books.SingleOrDefault();  // same like single but if the condition false is gonna return null instead throw an error

                //books.First();
                //books.FirstOrDefault();
                //books.Last();
                //books.LastOrDefault();

                //AGREGATE FUNCTION :  

                //books.Min(); 
                //books.Max();
                //books.Count();
                //books.Average();

                //books.Skip(2).Take(3);


        }

        private void NullableType()
        {
            /*
                NULLABLE TYPES : 
                    * is Value Types that have abillity to null;
            */

            //DateTime dateError = null;

            DateTime? date = null; //not Error

            Console.WriteLine(date.GetValueOrDefault()); //will return null;
            Console.WriteLine(date.HasValue); //will return boolean;
            //Console.WriteLine(date.Value); //will throw an error;
            
        }
    }
}
