using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTasks.Arrays
{
    /*
     * TASK: 442
     *
     * Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
     *
     * Find all the elements that appear twice in this array.
     *
     * Do it without extra space and in O(n) runtime.
     */
    
    public class FindAllDuplicatesInArray
    {
        public IList<int> FindDuplicates(int[] nums) {
            var output = new List<int>();
            foreach (var num in nums.GroupBy(x => x).Where(x => x.Count() == 2))
            {
                output.Add(num.Key);
            }

            return output;
        }
    }
}