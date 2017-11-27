namespace EnglishDigit
{
    using System;

    class Digit
    {
        private enum Digits
        {
            zero,
            one,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine
        };

        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine(ParseLastDigitToString(number));
        }

        static string ParseLastDigitToString(int number)
        {
            if (0 > number ^ number > 9)
            {
                number = ReturnLastDigit(number);
            }

            string digitAsString = Enum.GetName(typeof(Digits), number);

            return digitAsString;
        }

        static int ReturnLastDigit(int number)
        {
            int result;

            result = number % 10;

            return result;
        }
    }
}
