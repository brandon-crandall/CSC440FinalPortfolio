/// <summary>
/// SOURCE: Homework assignment in python class. (Python code at bottom)
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Create a function to change binary into decimal.
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace Demonstration_Programs
{
    //class ProgramOutputs
    //{
    //    static void Main()
    //    {
    //        BintoDec test = new BintoDec();
    //        Console.WriteLine(test.BinToDec("1100110101"));
    //        Console.WriteLine(test.BinToDec("1010101011"));
    //        Console.WriteLine();
    //        //Using a built in method to check answers.
    //        Console.WriteLine(Convert.ToInt32("1100110101", 2).ToString());
    //        Console.WriteLine(Convert.ToInt32("1010101011", 2).ToString());

    //    }
    //}
    class BintoDec
    {
        //Method to convert a binary string to a decimal
        public int BinToDec(string binary)
        {
            //parsing through the string to covert it into a number
            int num = Int32.Parse(binary);
            int decnum = 0;
            int temp = 0;
            //need to iterate through the number
            while (num > 0)
            {   
                //by dividing by 10 the remainder is the last digit
                //which will be a 1 or 0; then we can increase it by the
                //power of the temp number which increases by 1 each iteration
                decnum += num % 10 * (int)Math.Pow(2, temp);
                num = num / 10;
                temp++;
            }
            return decnum;
        }

    }
}
//MODIFICATIONS: Created myself but had to look up serveral difficulties related to string conversions.

//ANALYSIS: Changes a binary string into a number then iterates through the number by dividing by 10 and using the remainder.
//Faced several challenges that required me to find a different solution in C# when compared to python.

/* Sample Output
821
683

821
683
 */
/*
def bin_to_dec(bin_string):
    decimal = 0
    i = len(bin_string) - 1
    for char in bin_string:
        decimal += int (char) * pow(2, i)
        i -= 1
    return decimal

print(bin_to_dec("1100110101"))
print(bin_to_dec("1010101011"))
*/
