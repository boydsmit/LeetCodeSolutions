namespace LeetCodeTasks.Sort
{
    /*
     * TASK: 1528
     *
     * Given a string s and an integer array indices of the same length.
     *
     * The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
     *
     * Return the shuffled string.
     */
    
    public class ShuffleString
    {
        public string RestoreString(string s, int[] indices) {
            var charArray = s.ToCharArray();
            var outputArray = new char[indices.Length];
            for (var i = 0; i < indices.Length; i++)
            {
                outputArray[indices[i]] = charArray[i];
            }
            return new string(outputArray);
        }
    }
}