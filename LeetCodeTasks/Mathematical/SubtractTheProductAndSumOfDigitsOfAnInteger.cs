namespace LeetCodeTasks.Mathematical
{
    /*
     * TASK: 1281
     *
     * Given an integer number n, return the difference between the product of its digits and the sum of its digits.
     */
    
    public class SubtractTheProductAndSumOfDigitsOfAnInteger
    {
        public int SubtractProductAndSum(int n) {
            var intChars = n.ToString().ToCharArray();
            var prod = 0;
            var sum = 0;

            for (var i = 0; i < intChars.Length; i++)
            {
                var x = int.Parse(intChars[i].ToString());
                if (i==0)
                {
                    prod = x;
                }
                else
                {
                    prod *= x;
                }
    
                sum += x;   
            }
            return prod - sum;
        }
    }
}