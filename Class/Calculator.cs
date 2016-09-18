namespace ConsoleApplication.Class
{
    public class Calculator
    {
        public static int Add(int one , int two)
        {
            return one + two;
        }

        public int Add(params int[] numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
