namespace GetLargest
{
    using System;
    using System.Linq;

    class Largest
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] separator = { ' ' };

            int[] numbers = input.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            Console.WriteLine(GetMax(numbers));
        }

        static int GetMax(int[] numbers)
        {
            int max = int.MinValue;

            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }

        static int GetMax(int firstInt, int secondInt)
        {
            if (firstInt > secondInt)
            {
                return firstInt;
            }

            return secondInt;
        }
    }
}
