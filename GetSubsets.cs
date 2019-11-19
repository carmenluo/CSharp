using System;
using System.Collections.Generic;

namespace GetSubsets
{
    class GetSubsets
    {
        static int getSubsets(int [] arr, int total, int index, IDictionary<string, int> dict)
        {
            int to_return = 0;
            string key = total.ToString() + ":" + index.ToString();
            if (dict.ContainsKey(key)) {
                return dict[key];
            };
            if (total == 0)
            {
                return 1;
            } else if (index < 0)
            {
                return 0;
            } else if (arr[index]>total)
            {
               to_return = getSubsets(arr, total, index - 1, dict);
            } else
            {
               to_return =  getSubsets(arr, total, index - 1, dict) + getSubsets(arr, total-arr[index], index - 1, dict); ;
            }
            dict[key] = to_return;
            return to_return;
        }

        static void Main(string[] args)
        {
            IDictionary<string, int> dict = new Dictionary<string, int>();
            IDictionary<string, int[]> dictResult = new Dictionary<string, int[]>();
            int[] input = { 3, 6, 9, 1 };
            Array.Sort(input);
            int total = 9;
            Console.WriteLine(getSubsets(input, total, input.Length - 1, dict));
            Console.WriteLine("hello");
            int []arr = {5, 10, 15, 20, 25}; 
        }
    }
}
