/// <summary>
/// SOURCE: https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=netframework-4.8
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Shows several functions involved with manipulating stacks.
/// </summary>
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Demonstration_Programs
{
    /*
    class ProgramOutputs
    {
        static void Main()
        {
            // Creates and initializes a new Stack. Stacks are first in last out.
            Stack myStack = new Stack();
            myStack.Push("cow ");
            myStack.Push("brown ");
            myStack.Push("now ");
            myStack.Push("How ");
            // Displays the count and values of the Stack.
            Console.WriteLine("Creating my stack");
            Console.WriteLine("Count: {0}", myStack.Count);
            Console.Write("Values:");
            PrintValues(myStack);
            Console.ReadLine();
            // Removes an element from the Stack.
            Console.WriteLine("Poping the value off the top of the stack", myStack.Pop());
            Console.WriteLine("Count: {0}", myStack.Count);
            Console.Write("Values:");
            PrintValues(myStack);
            Console.ReadLine();
            // Views the first element in the Stack but does not remove it.
            Console.WriteLine("(Peek at the top value in the stack) {0}", myStack.Peek());
            Console.ReadLine();
            // Checks to see if the stack contains the given value.
            Console.WriteLine("Check if the stack contains 'How': {0}", myStack.Contains("How"));
            Console.ReadLine();

            // Clears the Stack.
            myStack.Clear();
            Console.WriteLine("Clearing the stack");
            Console.WriteLine("Count: {0}", myStack.Count);
            Console.Write("Values:");
            PrintValues(myStack);
            Console.ReadLine();

            void PrintValues(IEnumerable myCollection)
            {
                foreach (Object obj in myCollection)
                    Console.Write("{0}", obj);
                Console.WriteLine();
            }

        }
    }
    */
    class Stacks
    {

    }
}
//MODIFICATIONS: Used the basic formating from the microsft page then found other
//functions to demonstrate more methods.

//ANALYSIS: Shows how to create, delete, clear, count, peek and see if a stack contains a value.

/* Sample Output
Creating my stack
Count: 4
Values: How now brown cow

Poping the value off the top of the stack
Count: 3
Values: now brown cow

(Peek at the top value in the stack) now

Check if the stack contains 'How' : False

Clearing the stack
Count: 0
Values: 
 */
