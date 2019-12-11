/// <summary>
/// SOURCE: https://www.sanfoundry.com/csharp-program-divide-by-zero-exception/
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Simple error handling.
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace Demonstration_Programs
{

    class ExceptionDemo
    {
        /*
        static void Main()
        {
            //using a try/catch block to handle errors lets you keep the program from crashing.
            try
            {
                //Visual Studio will give you an error if you try to divide by 0 as an integer
                Console.WriteLine("Enter the number 0.");
                int input = int.Parse(Console.ReadLine());
                int result = 15 / input;
                Console.WriteLine(result);
                Console.WriteLine("You did not divide by zero.");
            }
            //Standard divide by zero error message
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message + " " + "Try again but this time don't divide by zero.");
                Console.ReadLine();
                Main();
            }
            
        }
        */

    }
}
//MODIFICATIONS: Added user input and allowed the program to continue after receiving the error message.

//ANALYSIS: Simple but effective way to deal with user input. 

/* Sample Output
Enter the number 0.
0
Attempted to divide by 0. Try again but this time don't divide by zero.
Enter the number 0.
1
15
You did not divide by zero.
 */
