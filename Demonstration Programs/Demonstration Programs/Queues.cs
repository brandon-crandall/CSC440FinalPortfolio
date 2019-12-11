/// <summary>
/// SOURCE: https://docs.microsoft.com/en-us/dotnet/api/system.collections.queue?view=netframework-4.8
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Shows several functions involved with manipulating queues.
/// </summary>
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Demonstration_Programs
{
    /*
    class Queues
    {
        public static void Main()
        {
            // Creates and initializes a new Queue.
            Queue myQ = new Queue();
            myQ.Enqueue("How");
            myQ.Enqueue("now");
            myQ.Enqueue("brown");
            myQ.Enqueue("cow");

            // Displays the properties and values of the Queue.
            Console.WriteLine("Count:    {0}", myQ.Count);
            Console.Write("Values:");
            PrintValues(myQ);
            Console.ReadLine();

            // Removes an element from the Queue.
            Console.WriteLine("Dequeueing an element from the queue.");
            Console.WriteLine("Dequeue: {0}", myQ.Dequeue());
            Console.Write("Values:");
            PrintValues(myQ);
            Console.ReadLine();

            // Views the first element in the Queue.
            Console.WriteLine("Peek at {0}", myQ.Peek());
            Console.Write("Values:");
            PrintValues(myQ);
            Console.ReadLine();

            //Clear the queue.
            Console.WriteLine("Clearing queue.");
            myQ.Clear();
            Console.Write("Values:");
            PrintValues(myQ);
            Console.ReadLine();
        }

        //The IEnumerable interface exposes an enumerator, which supports a simple iteration over a non-generic collection.
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
    */
}
//MODIFICATIONS: Used the basic formating from the microsft page then found other
//functions to demonstrate more methods.

//ANALYSIS: Shows how to queue, enqueue, clear and peek in a queue.

/* Sample Output
Count: 4
Values: How now brown cow

Dequeueing an element from the queue.
Dequeue: How
Values: now brown cow

Peek at now
Values: now brown cow

Clearing queue.
Values: 
 */
