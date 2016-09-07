using ConsoleApplication.Enumerator;
using ConsoleApplication.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

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
            program._DirectoryAndDirectoryInfo();

            Console.ReadLine();
        }

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
    }  
}
