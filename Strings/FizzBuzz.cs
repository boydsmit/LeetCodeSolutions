using System.Collections.Generic;

namespace LeetCodeTasks.Strings
{
    /*
     * TASK: 412
     * 
     * Write a program that outputs the string representation of numbers from 1 to n.
     *
     * But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output
     * “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.
     */
    
    public class FizzBuzz
    {
        public IList<string> Solution(int n) {
            var output = new List<string>();
            for (var i = 1; i < n +1; i++)
            {
                var str = "";
                if (i % 3 == 0) { str += "Fizz"; }
                if (i % 5 == 0) { str += "Buzz"; }
                str = str == "" ? i.ToString() : str;
                output.Add(str);
            }
            return output;
        }
    }
}