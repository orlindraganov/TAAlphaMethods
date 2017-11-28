namespace Utilities
{
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
