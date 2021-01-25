namespace LeetCodeTasks.Arrays
{
    /*
     * TASK: 509
     *
     * The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each
     * number is the sum of the two preceding ones, starting from 0 and 1. That is,
     *
     * F(0) = 0, F(1) = 1
     * F(n) = F(n - 1) + F(n - 2), for n > 1.
     *
     * Given n, calculate F(n).
     */
    
    public class FibonacciNumber
    {
        public int Fib(int N) {
            var output = 0;
            var oldNums = new int[2];
            oldNums[1] = 1;
            
            for (var i = 0; i <= N; i++)
            {
                if (i > 1)
                {
                    if (oldNums[1] != 0)
                    {
                        output = oldNums[0] + oldNums[1];
                    }
                    oldNums[0] = oldNums[1];
                    oldNums[1] = output;
                }
                else
                {
                    output = N;
                }
            }
            return output;
        }
    }
}