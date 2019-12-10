
/// <summary>
/// SOURCE: https://leetcode.com/problems/linked-list-cycle/
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Given a linked list, determine if it has a cycle in it.
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
    //        // LinkedListCycle.........

    //        LinkedListCycle newlist = new LinkedListCycle();
    //        newlist.AddFront(1);
    //        newlist.AddFront(2);
    //        newlist.AddFront(3);
    //        newlist.AddFront(4);
    //        newlist.HasCycle();
    //        newlist.head.next.next.next.next = newlist.head;
    //        newlist.HasCycle();
    //    }
    //}

    //Inheriting from the SinglyLinkedList class I created in order to get necessary methods
    class LinkedListCycle : SinglyLinkedList
    {
        //I used Floyd's Tortoise and Hare algorithm to solve this problem. The concept is that you use two pointers to move through the linked list
        //at different speeds. The tortoise moves one node at a time and the hare moves two. If they ever land on the same node then there is a cycle
        //but if the hare reaches null then there isn't a cycle.
        public bool HasCycle()
        {
            //Give them the same starting position
            ListNode tortoise = head;
            ListNode hare = head;

            //this loop is what moves them through the linkedlist
            while (hare != null && hare.next != null)
            {
                tortoise = tortoise.next;
                hare = hare.next.next;

                //if they are on the same node there is a cycle
                if (tortoise == hare)
                {
                    Console.WriteLine("It has a cycle!");
                    return true;
                }
            }
            Console.WriteLine("It does not have a cycle!");
            return false;
        }
    }
}
//MODIFICATIONS: Created this myself using Floyd's algorthm.

//ANALYSIS: Can determine if there is a cycle in a linkedlist

/* Sample Output
 It does not have a cycle!
 It has a cycle!
 */

