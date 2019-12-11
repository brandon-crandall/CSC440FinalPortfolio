
/// <summary>
/// SOURCE: https://leetcode.com/problems/fibonacci-number/
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, 
/// such that each number is the sum of the two preceding ones, starting from 0 and 1. 
/// Given N, calculate F(N).
/// </summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    //class ProgramOutputs
    //{
    //    static void Main(string[] args)
    //    {
    //        Fibonacci test = new Fibonacci();
    //        Console.WriteLine("Enter the number of places you want to see of the Fibonacci sequence.");
    //        int input = Convert.ToInt32(Console.ReadLine());
    //        for (int i = 0; i < input; i++)
    //        {
    //            Console.Write(test.Fib(i) + " ");
    //        }
    //    }
    //}
    class Fibonacci
    {
        //Method uses recursion (calls itself) to give the fibonacci sequence.
        public int Fib(int N)
        {
            // the first two numbers the of fibonacci sequence are 0, 1 
            // these are our stopping points for the recursion
            if (N == 0)
            {
                return 0;
            }
            if ( N == 1)
            {
                return 1;
            }
            else
            {
                return Fib(N - 2) + Fib(N - 1);
            }
        }
    }
}
//MODIFICATIONS: Created this using a recursive method I learned earlier in the semester.

//ANALYSIS: Uses recursion to construct the Fibonacci sequence.

/* Sample Output
 It does not have a cycle!
 It has a cycle!
 */
