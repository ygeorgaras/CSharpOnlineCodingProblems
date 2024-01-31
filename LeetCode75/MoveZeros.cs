using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class MoveZeros
    {
        public static void mZeros(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                //Finds first index of 0
                if (nums[i] == 0)
                {
                    int count = i;//Stores location to swap ints
                    int index = i + 1;//Iterator through nums array
                    while (index < nums.Length)
                    {
                        if (nums[index] == 0)
                        {
                            index++;
                        }
                        else
                        {
                            //Swap the nums[index] with the nums[count] and increment both 1
                            nums[count] = nums[index];
                            nums[index] = 0;
                            index++;
                            count++;
                        }
                    }
                    return;
                }
            }
        }
    }
}
