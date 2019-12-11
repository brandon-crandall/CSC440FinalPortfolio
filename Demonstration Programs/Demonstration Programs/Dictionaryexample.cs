/// <summary>
/// SOURCE: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.8
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Creates and utilizes functions related to dictionaries. 
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace Demonstration_Programs
{
    class Dictionaryexample
    {   
        /*
        static void Main()
        {
            Dictionary<String, int> mydict = new Dictionary<string, int>();

            //adding key, value to my dictionary
            //its worth noting that dictionaries do not allow two of the same keys
            mydict.Add("B", 1);
            mydict.Add("C", 1);
            mydict.Add("D", 1);
            mydict.Add("A", 1);
            mydict.Add("S", 1);

            //You can search for the value of a given key
            Console.WriteLine($"The value for C is {mydict["C"]}");

            //Can change a value easily
            mydict["B"] = 2;

            Console.WriteLine();
            //Can use a foreach loop with KeyValuePair<> to print out both the keys and the values.
            foreach (KeyValuePair<string, int> kvp in mydict)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
            Console.WriteLine();

            //Use the Remove method to remove a key/value
            mydict.Remove("A");
            foreach (KeyValuePair<string, int> keyvalue in mydict)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    keyvalue.Key, keyvalue.Value);
            }
            Console.WriteLine();

        }
        */
    }
}
//MODIFICATIONS: Attempted to recreat some of the original with what I thought were important methods.

//ANALYSIS: Dictionaries seem very versatile. I believe that these are the basic methods one should know to use dictionaries.

/* Sample Output
The value of C is 1

Key = B, Value = 2
Key = C, Value = 1
Key = D, Value = 1
Key = A, Value = 1
Key = S, Value = 1

Key = B, Value = 2
Key = C, Value = 1
Key = D, Value = 1
Key = s, Value = 1
*/
