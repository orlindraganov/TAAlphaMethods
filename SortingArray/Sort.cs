namespace SortingArray
{
    using System;
    using System.Linq;
    using System.Text;

    class Sort
    {
        static void Main()
        {
            var unneededArraySort = int.Parse(Console.ReadLine());

            var arr = ParseIntArr(Console.ReadLine());

            arr = SortArray(arr);

            Console.WriteLine(ParseString(arr));
        }

        private static string ParseString(int[] arr, char separator =' ')
        {
            var builder = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                builder.Append(arr[i]);
                builder.Append(separator);
            }

            return builder.ToString().Trim();
        }

        private static int[] SortArray(int[] input, bool isAscending = true)
        {
            var flipsCounter = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if ((isAscending) && (input[i] > input[i + 1]))
                {
                    input[i] = input[i] ^ input[i + 1];
                    input[i + 1] = input[i] ^ input[i + 1];
                    input[i] = input[i] ^ input[i + 1];

                    flipsCounter++;
                }
                if ((!isAscending) && (input[i] < input[i+1]))
                {
                    input[i] = input[i] ^ input[i + 1];
                    input[i + 1] = input[i] ^ input[i + 1];
                    input[i] = input[i] ^ input[i + 1];

                    flipsCounter++;
                }
            }

            if (flipsCounter > 0)
            {
                input = SortArray(input);
            }

            return input;
        }

        private  static int[] ParseIntArr(string str, char separator = ' ')
        {
            int[] numbers = str.Split(new char[] { separator }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            return numbers;
        }
    }
}
