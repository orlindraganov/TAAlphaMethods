namespace Utilities
{
    using System;
    using System.Linq;

    public class Parser
    {
        public static int[] ParseIntArr(string str)
        {
            int[] arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(s => int.Parse(s))
                             .ToArray();

            return arr;
        }
    }
}
