namespace ReverseNumber
{
    using System;
    using System.Text;

    class Reverse
    {
        static void Main()
        {
            var input = Console.ReadLine();
            Console.WriteLine(InvertString(input));
        }

        private static string InvertString(string input, bool shouldValidateNumber = true, char separator = '.')
        {
            var builder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (shouldValidateNumber)
                {
                    if (!ValidateNumberOrSeparator(input[i]))
                    {
                        throw new FormatException("Not a number of separator!");
                    }
                }
                builder.Insert(0, input[i]);
            }
            return builder.ToString();
        }

        private static bool ValidateNumberOrSeparator(char symbol, char separator = '.')
        {
            bool isNumOrSeparator = false;;

            if (char.IsNumber(symbol) || symbol == separator)
            {
                isNumOrSeparator = true;
            }

            return isNumOrSeparator;
        }
    }
}
