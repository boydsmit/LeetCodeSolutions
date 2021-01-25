namespace LeetCodeTasks.Arrays
{
    /*
     * TASK: 1480
     *
     * Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
     * Return the running sum of nums.
     */
    
    public class RunningSumOf1DArray
    {
        public int[] RunningSum(int[] nums) {
            var output = new int[nums.Length];
            var n = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                n = nums[i] + n;
                output[i] = n;
            }
            return output;
        }
    }
}