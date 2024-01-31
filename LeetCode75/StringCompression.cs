using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class StringCompression
    {

        public static int compress(char[] chars)
        {
            int indexAns = 0, index = 0;

            while (index < chars.Length)
            {
                char currentChar = chars[index];
                int count = 0;

                // Count occurrences of the current character
                while (index < chars.Length && chars[index] == currentChar)
                {
                    index++;
                    count++;
                }

                // Store the current character
                chars[indexAns++] = currentChar;

                // If more than one occurrence, store the count as well
                if (count != 1)
                {
                    foreach (char c in count.ToString())
                    {
                        chars[indexAns++] = c;
                    }
                }
            }

            return indexAns;
        }
    }
}
