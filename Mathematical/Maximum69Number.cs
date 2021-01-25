namespace LeetCodeTasks.Mathematical
{
    /*
     * TASK: 1323
     *
     * Given a positive integer num consisting only of digits 6 and 9.
     *
     * Return the maximum number you can get by changing at most one digit (6 becomes 9, and 9 becomes 6).
     */
    
    public class Maximum69Number
    {
        public int Max69Number (int num) {
            var charArray = num.ToString().ToCharArray();
            for (var i = 0; i < charArray.Length; i++)
            {
                if(charArray[i] ==  '6')
                {
                    charArray[i] = '9';
                    return int.Parse(string.Join("", charArray));
                }
            }
            return num;
        }
    }
}