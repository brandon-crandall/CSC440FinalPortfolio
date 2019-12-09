/// <summary>
/// SOURCE: https://leetcode.com/problems/valid-palindrome/
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
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
    //        Palindrome test = new Palindrome();
    //        string test1 = "racecar";
    //        string test2 = "whatwhat";
    //        string test3 = "a man, a plan, a canal: panama";
    //        string test4 = "race a car";

    //        Console.WriteLine(test.IsPalindrome(test1));
    //        Console.WriteLine(test.IsPalindrome(test2));
    //        Console.WriteLine(test.IsPalindrome(test3));
    //        Console.WriteLine(test.IsPalindrome(test4));
    //    }
    //}

    class Palindrome
    {

        // if true then it is a palindrome and if false then it is not a palindrome
        public bool IsPalindrome(string S)
        {
            // check to see if the provided string is empty or null
            // in this case empty is treated as a palindrome
            if (string.IsNullOrEmpty(S))
            {
                return true;
            }

            //we need to check if both ends of the string match up and for this
            //particular problem we are ignoring punctuation 
            int front = 0,  back= S.Length - 1;

            // we just go till the front and back meet up
            while (front < back)
            {
                // checks if the front pointer is pointing at something
                // other than a letter or digit and moves forward in order to 
                //ignore punctuation
                if (!char.IsLetterOrDigit(S[front]))
                {
                    front++;
                }

                // checks if the back pointer is pointing at something
                // other than a letter or digit and moves backward
                else if (!char.IsLetterOrDigit(S[back]))
                {
                    back--;
                }

                //checking to see if the front and back letters don't match, if they don't then we 
                //no longer need to continue checking
                else if (char.ToLower(S[front++]) != char.ToLower(S[back--]))
                {
                    return false;
                }
            }

            // if it completes the loop then it is a palindrome
            return true;

        }
       
    }
}
//MODIFICATIONS: Created this myself working with another classmate.

//ANALYSIS: Can determine if a string is a palindrome.

/* Sample Output
True
False
True
False
 */
