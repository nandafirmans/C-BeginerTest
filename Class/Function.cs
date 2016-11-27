using ConsoleApplication.Enumerator;
using System;
using System.Collections.Generic;

namespace ConsoleApplication.Class
{
    public class Function
    {

        public static string Shipment(string str)
        {
            switch (str) 
            {
                case "Regular":
                    return ShippingEnum.Regular.ToString();

                case "Registered":
                    return ShippingEnum.Registered.ToString();

                case "Express":
                    return ShippingEnum.Express.ToString();

                default:
                    return "Error Method Doesnt Exist";
            }
        }

        public static int Increment(int number)
        {
            number += 10;

            return number;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

        public static string SummarizingText(string text)
        {
            const int maxLength = 20;

            if (text.Length < maxLength)
            {
                return text;
            }
          
            var words = text.Split(' '); // spliting by the given parameter, and return it as an array of string
            var summaryWords = new List<string>(); // create new list for containing the result of array string
            var totalCharacter = 0;
            var summary = "";

            foreach (var word in words) //loops inside the array of string 
            {
                summaryWords.Add(word); // adding an array of string to List<> of string

                totalCharacter += word.Length + 1; //every words will count
                if (totalCharacter > 20)           // if its reach 20 char it will stop and get out of the loop
                {
                    break;
                }
            }

            summary = String.Join(" ", summaryWords) + "...";

            return summary;
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            
            return new string(array);
        }
    }
}
