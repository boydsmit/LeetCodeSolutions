using System.Linq;

namespace LeetCodeTasks.Arrays
{
    /*
     * TASK: 1295
     *
     * Given an array nums of integers, return how many of them contain an even number of digits. 
     */
    public class FindNumbersWithEvenNumberOfDigits
    {
        public int FindNumbers(int[] nums) {
            return nums.Count(x => (x.ToString().Length % 2).Equals(0));    
        }
    }
}