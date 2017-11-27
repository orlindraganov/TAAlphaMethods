namespace LargerThanNeighbours
{
    using System;
    using System.Linq;

    class Larger
    {
        static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            Console.WriteLine(CountLargerThanNeighbours(arr));
        }

        static int CountLargerThanNeighbours(int[] arr)
        {
            var counter = 0;

            //Check conditions
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i-1] && arr[i]>arr[i+1])
                {
                    counter++;

                    //Next one can't be bigger than this one, 
                    //so we hop to the next i :)
                    i++;
                }
            }

            return counter;
        }
    }
}
