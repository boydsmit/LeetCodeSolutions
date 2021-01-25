using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTasks.Arrays
{
    /*
     * TASK: 1431
     * 
     * Given the array candies and the integer extraCandies, where candies[i] represents the number of candies that the ith kid has.
     *
     * For each kid check if there is a way to distribute extraCandies among the kids such that he or she can have the greatest 
     * number of candies among them. Notice that multiple kids can have the greatest number of candies.
     */
    
    public class KidsWithTheGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies) { 
            IList<bool> bools = new List<bool>();

            foreach (var candyCount in candies)
            {
                if (candyCount + extraCandies >= candies.Max())
                {
                    bools.Add(true);
                }
                else
                {
                    bools.Add(false);
                }
            }
            return bools;
        }
    }
}