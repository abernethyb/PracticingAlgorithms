using System;

namespace twosum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 2, 11, 5, 5 };
            TwoSum(inputArray, 10);
        }

        /*
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.

        Example 1:
        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Output: Because nums[0] + nums[1] == 9, we return [0, 1].

        */
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] sumsTwo = { };
            for (int i = 0; i <= nums.Length - 2; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    //Console.WriteLine($"{nums[i]} + {nums[j]}");
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"{i},{j}");
                        int[] sums = { i, j };
                        return sums;
                    }
                }
            }
            int[] noSumFound = { 0, 0 };
            return noSumFound;
        }
    }
}