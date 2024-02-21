using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class FindWinners
    {
        public static IList<IList<int>> getWinners(int[][] matches)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int[] match in matches)
            {

                //Adds winner to dictionary and sets loses value to 0
                if (!(counts.ContainsKey(match[0])))
                {
                    counts.Add(match[0], 0);
                }

                //Adds loser to the dictionary, increment loses value
                if (counts.ContainsKey(match[1]))
                {
                    counts[match[1]]++;
                }
                else
                {
                    counts.Add(match[1], 1);
                }
            }

            List<int> winners = new List<int>();
            List<int> oneLose = new List<int>();

            foreach (int key in counts.Keys) 
            {
                if (counts[key] == 0)
                {
                    winners.Add(key);
                }else if (counts[key] == 1)
                {
                    oneLose.Add(key);
                }
            }

            winners.Sort();
            oneLose.Sort();

            return new List<IList<int>> { winners, oneLose};
        }
    }
}
