namespace AppearanceCount
{
    using System;
    using System.Linq;

    class Count
    {
        static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            var number = int.Parse(Console.ReadLine());

            Console.WriteLine(CountAppearance(arr, number));
        }

        static int CountAppearance(int[] searchableArray, int numberForSearching)
        {
            int counter = 0;

            foreach (var currentNumber in searchableArray)
            {
                if (currentNumber == numberForSearching)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
