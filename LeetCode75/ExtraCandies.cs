using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class ExtraCandies
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> mostCandiesList = new List<bool>();
            var highestAmountOfCandies = candies.Max();

            foreach (var cand in candies)
            {
                if(cand + extraCandies >= highestAmountOfCandies)
                {
                    mostCandiesList.Add(true);
                }
                else
                {
                    mostCandiesList.Add(false);
                }
            }
            
            return mostCandiesList;
        }
    }
}
