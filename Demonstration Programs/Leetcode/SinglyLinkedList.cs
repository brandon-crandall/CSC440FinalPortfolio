using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    //class ProgramOutputs
    //{
    //    static void Main(string[] args)
    //    {
    //        SinglyLinkedList newlist = new SinglyLinkedList();
    //        newlist.AddFront(1);
    //        newlist.AddFront(2);
    //        newlist.AddFront(3);
    //        newlist.AddFront(4);
    //        newlist.PrintList();
    //    }
    //}
    class SinglyLinkedList
    {
        //Creating a node of a linked list
        public class ListNode
        {
            //value stored in a node
            public int value;
            //this is the pointer portion of a node
            public ListNode next;

            public ListNode(int value)
            {
                this.value = value;
                next = null;
            }
        }
        //Creating a method to add values to a linkedlist
        public ListNode head;
        public void AddFront(int Value)
        {
            ListNode newNode = new ListNode(Value);

            newNode.next = head;

            head = newNode;
        }
        //the tostring method likes to display the data type so we write a method to print on the linkedlist
        public void PrintList()
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.value + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

    }
}
