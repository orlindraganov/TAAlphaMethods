namespace IntegerCalculations
{
    using System;
    using System.Linq;
    using System.Numerics;

    class IntCalculations
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            Console.WriteLine(GetMinimum(numbers));
            Console.WriteLine(GetMaximum(numbers));
            Console.WriteLine("{0:F2}", CalculateAverage(numbers));
            Console.WriteLine(CalculateSum(numbers));
            Console.WriteLine(CalculateProduct(numbers));
        }

        static int GetMinimum(int[] numbers)
        {
            var minimum = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }

            return minimum;
        }

        static int GetMaximum(int[] numbers)
        {
            var maximum = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
            }

            return maximum;
        }

        static double CalculateAverage(int[] numbers)
        {
            var sum = 0;

            int index;

            for (index = 0; index < numbers.Length; index++)
            {
                sum += numbers[index];
            }

            double average = (double)sum / index;

            average = Math.Round(average, 2);

            return average;
        }

        static int CalculateSum(int[] numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        static BigInteger CalculateProduct(int[] numbers)
        {
            BigInteger product = 1;

            foreach (var number in numbers)
            {
                product *= number;
            }

            return product;
        }
    }
}
