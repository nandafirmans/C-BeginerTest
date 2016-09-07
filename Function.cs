using System;
using System.Collections.Generic;
using ConsoleApplication.Enumerator;

namespace ConsoleApplication
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
          
            var words = text.Split(' ');
            var summaryWords = new List<string>();
            var totalCharacter = 0;
            var summary = "";

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacter += word.Length + 1;
                if (totalCharacter > 20)
                {
                    break;
                }
            }

            summary = String.Join(" ", summaryWords) + "...";

            return summary;
        }
    }
}
