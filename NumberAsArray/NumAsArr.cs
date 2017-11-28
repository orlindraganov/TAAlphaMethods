namespace NumberAsArray
{
    using System;
    using System.Linq;
    using System.Text;

    class NumAsArr
    {
        static void Main()
        {
            var sizes = Parser.ParseIntArr(Console.ReadLine(), " ");
            var firstArr = Parser.ParseIntArr(Console.ReadLine(), " ");
            var secondArr = Parser.ParseIntArr(Console.ReadLine(), " ");

            firstArr = Transformer.Reverse(firstArr);
            secondArr = Transformer.Reverse(secondArr);

            var firstNum = Parser.ParseInt(firstArr);
            var secondNum = Parser.ParseInt(secondArr);
            var result = firstNum + secondNum;

            var resultArr = Parser.ParseIntArr(result);
            resultArr = Transformer.Reverse(resultArr);

            Console.WriteLine(Parser.ParseString(resultArr));
        }

        public class Transformer
        {
            public static int[] Reverse(int[] input)
            {
                var output = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    var outputIndex = input.Length - i - 1;

                    output[outputIndex] = input[i];
                }

                return output;
            }
        }

        public class Parser
        {
            public static string ParseString(int[] arr, string separator = " ")
            {
                var builder = new StringBuilder();

                for (int i = 0; i < arr.Length; i++)
                {
                    builder.Append(arr[i]);
                    builder.Append(separator);
                }

                return builder.ToString().Trim();
            }

            public static int ParseInt(int[] arr)
            {
                var builder = new StringBuilder();

                for (int i = 0; i < arr.Length; i++)
                {
                    builder.Append(arr[i]);
                }

                var output = int.Parse(builder.ToString());
                return output;
            }

            public static int[] ParseIntArr(int number)
            {
                var str = number.ToString();
                return ParseIntArr(str);
            }

            public static int[] ParseIntArr(string str)
            {
                int[] numbers = new int[str.Length];

                for (int i = 0; i < str.Length; i++)
                {
                    numbers[i] = int.Parse(str[i].ToString());
                }

                return numbers;
            }

            public static int[] ParseIntArr(string str, string separator)
            {
                int[] arr = str.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(s => int.Parse(s))
                                 .ToArray();

                return arr;
            }
        }

        public class Comparer
        {
            public static int GetMax(int firstInt, int secondInt)
            {
                if (firstInt > secondInt)
                {
                    return firstInt;
                }

                return secondInt;
            }

            public static int GetMax(int[] numbers)
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
        }
    }
}
