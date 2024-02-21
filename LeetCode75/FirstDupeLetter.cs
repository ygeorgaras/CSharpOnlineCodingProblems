using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class FirstDupeLetter
    {

        public char RepeatedCharacter(string s)
        {
            HashSet<char> result = new HashSet<char>();
            
            foreach (char c in s) {
                if(result.Contains(c))
                {
                    return c;
                }
                result.Add(c);
            }
            return ' ';
        }
    }
}
