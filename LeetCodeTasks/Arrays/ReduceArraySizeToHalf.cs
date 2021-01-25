using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTasks.Arrays
{
    /*
     * TASK: 1338
     *
     * Given an array arr.  You can choose a set of integers and remove all the occurrences of these integers in the array.
     *
     * Return the minimum size of the set so that at least half of the integers of the array are removed.
     */
    
    public class ReduceArraySizeToHalf
    {
        public int MinSetSize(int[] arr) {
            var dict = new Dictionary<int,int>();
            foreach (var num in arr)
            {
                if (!dict.ContainsKey(num))
                {
                    dict[num] = 0;
                }
                dict[num]++;
            }

            var nums = dict.Values.ToList();
            nums.Sort((x, y) => y.CompareTo(x));
            var sum = 0;
        
            for(var i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
                if(sum >= arr.Length / 2)
                    return i + 1;
            }
            return 0;
        }
    }
}