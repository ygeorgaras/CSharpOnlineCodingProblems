using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodingProblems.LeetCode75
{
    internal class CanPlaceFlowers
    {
        public static bool PlaceFlowers(int[] flowerbed, int n)
        {
            for(int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    //If i is 0 then there is nothing to the left
                    var emptyLeftPlot = (i == 0) || (flowerbed[i - 1] == 0);
                    //If i is the length-1 then there is nothing to the right
                    var emptyRightPlot = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);
                    if(emptyLeftPlot && emptyRightPlot)
                    {
                        flowerbed[i] = 1;
                        n--;
                    }
                }
                if(n <= 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
