namespace LeetCodeTasks.Arrays
{
    /*
     * TASK: 1512
     *
     * Given an array of integers nums.
     *
     * A pair (i,j) is called good if nums[i] == nums[j] and i < j.
     *
     * Return the number of good pairs.
     */
    
    public class NumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums) {
            var output = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (i < j && nums[i] == nums[j])
                    {
                        output++;
                    }
                }
            }
            return output;
        }
    }
}