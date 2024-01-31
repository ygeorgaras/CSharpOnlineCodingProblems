using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class IncreaseTripletSequence
    {
        public static bool IncreasingTriplet(int[] nums)
        {
            int lowestNum = int.MaxValue;
            int highestNum = int.MaxValue;
            foreach(int num in nums)
            {
                if(num <= lowestNum) 
                {
                    lowestNum = num;
                }else if(num <= highestNum)
                {
                    highestNum = num;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
