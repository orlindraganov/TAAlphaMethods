namespace FirstLargerThanNeighbours
{
    using System;
    using System.Linq;

    class FirstLarger
    {
        static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            Console.WriteLine(IndexOfFirstLarger(arr));
        }

        static int IndexOfFirstLarger(int[] arr)
        {
            var index = -1;

            //Check conditions
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
