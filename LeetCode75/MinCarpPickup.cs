using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MinCardPickup
    {
        public static int getMinCardPickup(int[] cards)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int,int>();
            int ans = int.MaxValue;

            for (int i = 0; i < cards.Length; i++)
            {

                if (keyValuePairs.ContainsKey(cards[i]))
                {
                    ans = Math.Min(ans, i - keyValuePairs[cards[i]] + 1);
                    keyValuePairs[cards[i]] = i;
                }
                else
                {
                    keyValuePairs.Add(cards[i], i);
                }                
            }

            if(ans == int.MaxValue)
            {
                return -1;
            }

            return ans;
        }
    }
}
