using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.LeetCode75
{
    internal class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] leftProducts = new int[n];
            int[] rightProducts = new int[n];
            int[] answer = new int[n];

            // Initialize leftProducts
            leftProducts[0] = 1;
            for (int i = 1; i < n; i++)
            {
                leftProducts[i] = nums[i - 1] * leftProducts[i - 1];
            }
            // Initialize rightProducts
            rightProducts[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                rightProducts[i] = nums[i + 1] * rightProducts[i + 1];
            }

            // Calculate the final result
            for (int i = 0; i < n; i++)
            {
                answer[i] = leftProducts[i] * rightProducts[i];
                Console.WriteLine(leftProducts[i] + " * " + rightProducts[i] + " = " + answer[i]);
            }

            return answer;
        }

    }
}
