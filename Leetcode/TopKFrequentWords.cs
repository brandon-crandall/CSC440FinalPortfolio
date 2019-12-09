/// <summary>
/// SOURCE: https://leetcode.com/problems/top-k-frequent-words/
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Given a non-empty list of words, return the k most frequent elements.
/// Your answer should be sorted by frequency from highest to lowest. 
/// If two words have the same frequency, then the word with the lower alphabetical order comes first.
/// </summary>
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Leetcode
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        TopKFrequentWord activate = new TopKFrequentWord();
    //        string[] arr1 = { "Ready", "player", "one", "Ready", "player", "two" };
    //        int k = 2;

    //        Console.WriteLine(string.Join(System.Environment.NewLine, activate.TopKFrequent(arr1, k)));
    //    }
    //}

    public class TopKFrequentWord
    {
        // This method will return a list with the words that appear k times
        public IList<string> TopKFrequent(string[] words, int k)
        {
            // create dictionary from the string array words in order to hold each word
            //and the number of times it has appeared
            IDictionary<string, int> myDict = new Dictionary<string, int>();

            // cycle through the array
            foreach (var word in words)
            {
                // if dictionary already contains the word increase the value by 1
                if (myDict.ContainsKey(word))
                {
                    myDict[word]++;
                }

                // if the dictionary does not contain the word then add the word
                //to the dictionary and set the value to 1 since this is its first
                //appearance
                else
                {
                    myDict.Add(word, 1);
                }

            }

            // create a list to hold the key from dictionary
            IList<string> answer = new List<string>();

            // we cycle through the dictionary, sort the words by the number of times it has appeared
            // and then alphabetically
            foreach (var item in myDict.OrderByDescending(R => R.Value).ThenBy(R => R.Key))
            {
                // since we were give the max times the most frequent word appears we only need
                // to do it k times
                if (k > 0)
                {
                    // add key to the list
                    answer.Add(item.Key);
                    //reduce k by 1
                    k--;
                }
            }

            // return the list
            return answer;
        }
    }
}
//MODIFICATIONS: Worked on this with a classmate.

//ANALYSIS: Can determine the k most frequent words.

/* Sample Output
player
Ready
 */
