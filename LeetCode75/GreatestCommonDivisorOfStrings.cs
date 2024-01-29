using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class GreatestCommonDivisorOfStrings
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            //Checks to see if both of the strings are compatible 
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }

            int a = str1.Length;
            int b = str2.Length;

            //Once we know they're compatible we can iterate through to find the GCD
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
                
            return str1.Substring(0, a);
        }
    }
}
