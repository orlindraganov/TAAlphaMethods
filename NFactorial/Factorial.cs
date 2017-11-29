namespace NFactorial
{
    using System;
    using System.Numerics;

    class Factorial
    {
        static void Main()
        {
            BigInteger number = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorial(number));
        }

        static BigInteger CalculateFactorial(BigInteger number)
        {
            if (number <= 1)
            {
                return 1;
            }

            return number * CalculateFactorial(number - 1);
        }
    }
}