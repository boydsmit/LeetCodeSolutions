namespace LeetCodeTasks.Strings
{
    /*
     * TASK: 344
     *
     * Write a function that reverses a string. The input string is given as an array of characters char[].
     *
     * Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
     *
     * You may assume all the characters consist of printable ascii characters.
     */
    
    public class ReverseString
    {
        public void Reverse(char[] s) {
              
            var j = s.Length - 1;
            for (var i = 0; i < s.Length / 2; i++)
            {
                var oldChar = s[i];
                s[i] = s[j];
                s[j] = oldChar;
                j--;
            }
        }
    }
}