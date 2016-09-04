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
    }
}
