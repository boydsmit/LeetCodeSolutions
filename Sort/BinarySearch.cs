namespace LeetCodeTasks.Sort
{
    /*
     * TASK: 704
     * 
     * Given a sorted (in ascending order) integer array nums of n elements and a target value, write a function to search
     * target in nums. If target exists, then return its index, otherwise return -1.
     */
    
    public class BinarySearch
    {
        public int Search(int[] nums, int target) {
            var l = 0;
            var r = nums.Length -1;
            while (l <= r)
            {
                var mid = l + (r - l)/2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                
                if(nums[mid] < target)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return -1;
        }   
    }
}