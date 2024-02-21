using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MaxNumOfWordsInString
    {
        public static int getMaxNumOfWords(string text)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>() { };

            foreach (char word in text)
            {
                if ("balloon".Contains(word))
                {
                    if (letters.ContainsKey(word))
                    {
                        letters[word]++;
                    }
                    else
                    {
                        letters[word] = 1;
                    }
                }
            }
            if(letters.Count != 5)
            {
                return 0;
            }

            int balloon = letters['b'];
            balloon = Math.Min(balloon, letters['a']);
            balloon = Math.Min(balloon, letters['l'] / 2);
            balloon = Math.Min(balloon, letters['o'] / 2);
            balloon = Math.Min(balloon, letters['n']);
            
            return balloon;
        }


    }
}
