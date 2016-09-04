using ConsoleApplication.Enumerator;
using ConsoleApplication.Math;
using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

            //program.LectureOne();
            //program.LectureTwo();
            //program.LectureThree();
            //program.LectureFour(3);
            //program.LectureFive();
            //program.LectureSix();
            //program.LectureSeven();
            //program.LectureEight();
            program.LectureNine();

            Console.ReadLine();
        }

        public void LectureOne() //class
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

        public void LectureTwo() //array
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

        public void LectureThree() //string
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

        public void LectureFour(int id) //enum
        {
            var methodName = Function.Shipment( Convert.ToString((ShippingEnum)id) ); // send integer from parameter  and get return as a string

            var objectEnum = Enum.Parse(typeof(ShippingEnum), methodName); // use return from 'Function.Shipment' and cast it into an enum as an object

            var realEnum = (ShippingEnum)objectEnum; // convert object enum to an 'enum'

            var methodId = (int)realEnum; //get value from and realenum and cast it to an integer

            Console.WriteLine( Convert.ToString($"Shipping Name : {methodName} , Shipping ID : {methodId}") ); // JURUS BARU (STRING INTERPOLATION)
        }

        public void LectureFive() // value and refrence types
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

        public void LectureSix() // iteration
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

        public void LectureSeven() // Random Class
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

        public void LectureEight() // Array
        {
            var number = new int[] {5, 9, 12, 3, 1, 7};

            //Length
            Console.WriteLine("Result of Legth");
            Console.WriteLine(number.Length); // Length method counting the length of an array 

            //IndexOF   
            var index = Array.IndexOf(number, 1); //search index of the value in array
            Console.WriteLine("Result of IndexOf() method");
            Console.WriteLine($"Index of 1 in array is : {index}");

            //Clear
            Array.Clear(number, 0, 2); // clear value inside an array ' in case integer so the value should be 0 (if its a string or an object it should be null)' 
            Console.WriteLine("Result of Clear() method");

            foreach (var num in number)
            {
                Console.WriteLine(num);
            }

            //Copy 
            var pasteArray = new int[3];
            Array.Copy(number, pasteArray, 3); // copying a value of a targeted array to new array
            Console.WriteLine("Result of Copy() method");

            foreach (var item in pasteArray)
            {
                Console.WriteLine(item);
            }

            //Sort
            Array.Sort(number);
            Console.WriteLine("Result of Sort() method");

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
        }

        public void LectureNine()
        {
            var numbers = new List<int>() {1, 2, 3, 4};

            //Add()
            numbers.Add(1);

            //AddRange()
            numbers.AddRange(new []{ 7, 8, 9});

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
    }  
}
