namespace AddingPolynomials
{
    using System;
    using System.Linq;
    using System.Text;

    class Adding
    {
        static void Main()
        {
            var unneededArrSize = int.Parse(Console.ReadLine());

            int[] firstPolynomial = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
            int[] secondPolynomial = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            int[] result = AddingPolynomials(firstPolynomial, secondPolynomial);

            Console.WriteLine(ParseString(result));
        }

        private static int[] AddingPolynomials(int[] firstPolynomial, int[] secondPolynomial)
        {
            if (firstPolynomial.Length != secondPolynomial.Length)
            {
                throw new ArgumentException("The arrays should have the same length");
            }

            var result = new int[firstPolynomial.Length];

            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                result[i] = firstPolynomial[i] + secondPolynomial[i];
            }

            return result;
        }

        private static string ParseString(int[] arr, char separator = ' ')
        {
            var builder = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                builder.Append(arr[i]);
                builder.Append(separator);
            }

            return builder.ToString().Trim();
        }
    }
}