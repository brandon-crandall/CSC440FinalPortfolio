/// <summary>
/// SOURCE: https://leetcode.com/problems/two-sum/
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Given an array of integers, return indices of the two numbers such that they add up to a specific target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// </summary>
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    //class ProgramOutputs
    //{
    //    static void Main(string[] args)
    //    {
    //        TwoSum test = new TwoSum();
    //        int[] numbers = new int[] { 2, 7, 11, 15 };
    //        Console.WriteLine(string.Join(System.Environment.NewLine, test.TwoSumSolution(numbers, 9)));

    //    }
    //}
    class TwoSum
    {
        //Goes through the array and finds two numbers that add up to the target number
        public int[] TwoSumSolution(int[] nums, int target)
        {   
            //iterate through using a loop that stops when it gets to the last number
            for (int i = 0; i < nums.Length; i++)
            {   
                //iterate through to subtract "i" from the target until it equal "j" 
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target - nums[i] == nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
//MODIFICATIONS: Created this myself.

//ANALYSIS: Uses a nested for loop to determine which two numbers in an array equal the target number then returns the indices. 

/* Sample Output
0
1
 */
