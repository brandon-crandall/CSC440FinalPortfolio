/// <summary>
/// SOURCE: https://leetcode.com/problems/reverse-linked-list/
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Given a linked list, reverse it.
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
    //        ReverseLinkedList newlist = new ReverseLinkedList();
    //        newlist.AddFront(1);
    //        newlist.AddFront(2);
    //        newlist.AddFront(3);
    //        newlist.AddFront(4);
    //        newlist.PrintList();
    //        newlist.ReverseList();
    //        newlist.PrintList();
    //    }
    //}

    //Inheriting from the SinglyLinkedList class I created in order to get necessary methods
    class ReverseLinkedList : SinglyLinkedList
    {
        //Function to reverse a linked list
        public void ReverseList()
        {
            //end up using 3 points (prev, curr, nextTemp) in order to turn the pointers to the previous node
            //while not losing the rest of the linkedlist because that would technically be a memory leak which
            //is handled by the garbage collector in C# but that isn't the case in every programming language
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            //we point the end to what was originally the last node to now make it the first node
            head = prev;
        }
    }
}
//MODIFICATIONS: Created this myself 

//ANALYSIS: Reverses a Linked List and uses inheritance from the SinglyLinkedList class I created.

/* Sample Output
4 3 2 1
1 2 3 4
 */
