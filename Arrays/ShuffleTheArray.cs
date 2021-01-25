namespace LeetCodeTasks.Arrays
{
    /*
     * TASK: 1470
     *
     * Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
     *
     * Return the array in the form [x1,y1,x2,y2,...,xn,yn].
     */
    
    public class ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n) {
            var output = new int[nums.Length];
            for (var i = 0; i < n * 2; i++)
            {
                if (i % 2 == 0)
                {
                    output[i] = nums[i / 2];
                }
                else
                {
                    output[i] = nums[i / 2 + n];
                }
            }
            return output;
        }
    }
}