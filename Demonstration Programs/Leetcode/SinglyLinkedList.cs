/// <summary>
/// SOURCE: I originally learned to create a SinglyLinkedList class from Razvan Mezei. (Original code at the bottom after my code.)
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: I created a SinglyLinkedList class to use with Leetcode problems. 
/// Created several methods such as adding a node to the front, Printing a linkedlist, Deleting nodes, etc.
/// </summary>
/// 
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
    //        newlist.AddBack(5);
    //        newlist.PrintList();
    //        newlist.DeleteFront();
    //        newlist.PrintList();
    //        newlist.Delete(1);
    //        newlist.PrintList();
    //        newlist.ClearAll();

    //    }
    //}
    class SinglyLinkedList
    {
        public ListNode head;
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
        public void AddFront(int Value)
        {
            ListNode newNode = new ListNode(Value);

            newNode.next = head;

            head = newNode;
        }

        //Creating a method to add values to the end of the linkedlist which requires
        //code to iterate throught the data structure
        public void AddBack(int someValue)
        {
            //create a new node
            ListNode newNode = new ListNode(someValue);

            //Check if there are any values
            if (head == null)
                head = newNode;
            else
            {
                //find the last node that is not null
                ListNode curr = head;
                while (curr.next != null)
                {
                    curr = curr.next;//move to the next node
                }
                //link the last node to new node
                curr.next = newNode;
            }
        }

        //Method to delete the front node. 
        public void DeleteFront()
        {
            //First checking to see if there is anything to delete.
            if (head == null)
                throw new Exception("The List is already empty");
            //Just move the head variable to the next node to remove the first node from the list.
            else
                head = head.next;
        }

        //To delete a specific node we need a method to iterate through the linkedlist and find that value
        //then connect the link pointing to the node to be delete is set to point to the node after it.
        public void Delete(int someValue)
        {
            //checking to see if there are any values
            if (head==null)
                throw new Exception("The list is empty!");
            //checking if there is only one node
            else if (head.next == null)
            {
                if (head.value == someValue)
                    head = null;
                else
                    Console.WriteLine("Value not found");
            }
            else
            {
                //interating through until we find the currect node
                ListNode curr = head;
                while (curr.next != null && curr.next.value != someValue)
                    curr = curr.next;
                //if we find it then we stop right before the node we want to delete and connect the point to the node after
                if (curr.next != null)
                    curr.next = curr.next.next;
                else
                    Console.WriteLine("Value not found");
            }
        }

        //To delete the whole linkedlist head just needs to be set to null
        public void ClearAll()
        {
            head = null;
        }

        //the tostring method likes to display the data type so we write a method to print the linkedlist
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
//MODIFICATIONS: Recreated a SinglyLinkedList class based off the one Razvan Mezei created in class.

//ANALYSIS: I was able to recreate many of the methods without needing to check but I did need to check back for the
//delete anywhere in the linkedlist method. Overall this is a functional linkedlist.

/* Sample Output
4 3 2 1
4 3 2 1 5
3 2 1 5
3 2 5

 */

/* 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC390_SLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node someNode = new Node(17);
            Console.WriteLine("|cat| " + someNode + " |cat|");

            SinlgyLinkedList mylist = new SinlgyLinkedList();
            mylist.Print();
            mylist.AddFront(1);
            mylist.AddFront(2);
            mylist.AddFront(3);
            mylist.Print();
            mylist.AddBack(10);
            mylist.AddBack(20);
            mylist.AddBack(30);
            mylist.Print();
            mylist.DeleteFront();
            mylist.DeleteFront();
            mylist.Print();
            mylist.DeleteBack();
            mylist.Print();
            //mylist.ClearAll();
            mylist.Print();
            mylist.AddBack(30);
            mylist.Print();
            mylist.Delete(20);
            mylist.Print();
            mylist.Delete(20);
            mylist.Print();
        }
    }

    class Node
    {
        //data
        public int data;//this is the stored value
        public Node next;

        //methods
        public override string ToString()
        {
            return Convert.ToString(data);
        }

        //ctor
        public Node(int newValue)
        {
            data = newValue;
            next = null;
        }
    }

    class SinlgyLinkedList
    {
        //data
        Node head;

        //methods
        public bool IsEmpty()
        {
            //if (head == null)
            //    return true;
            //else
            //    return false;
            return head == null;
        }
        public void ClearAll()
        {
            head = null;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Printing the list:");
            if (IsEmpty())
                Console.WriteLine("the list is empty ...");
            else
            {
                Node finger = head;
                while (finger != null)
                {
                    Console.Write(finger + "  "); //display the node
                    finger = finger.next; //move to the next node
                }
                Console.WriteLine();
            }
        }

        public void AddFront(int someValue)
        {
            //make a new node
            Node newNode = new Node(someValue);

            //link this new node to the head of the list
            newNode.next = head;

            //move the head
            head = newNode;
        }
        public void AddBack(int someValue)
        {
            //create a new node
            Node newNode = new Node(someValue);

            if (IsEmpty())
                head = newNode;
            else
            {

                //find the last non-null node
                Node finger = head;
                while (finger.next != null)
                {
                    finger = finger.next;//move finger to the right
                }
                //link the last node to new node
                finger.next = newNode;
            }
        }

        public void DeleteFront()
        {
            if (IsEmpty())
                throw new Exception("you can't delete the front of an empty list!");
            else
                head = head.next;
        }
        public void DeleteBack()
        {
            if (IsEmpty())//
                throw new Exception("you can't delete the back of an empty list!");
            else if (head.next == null)//the list has only one node
                head = null;
            else
            {
                Node finger = head;//find the node next to last that is not null
                while (finger.next.next != null)
                    finger = finger.next;

                finger.next = null;//link out the last node
            }
        }

        public void Delete(int someValue)
        {
            if (IsEmpty())
                throw new Exception("you can't delete the front of an empty list!");
            else if (head.next == null)//i.e. we have only one node in the list
            {
                if (head.data == someValue)
                    head = null;
                else
                    Console.WriteLine("value no found");
            }
            else
            {
                Node finger = head;
                while (finger.next != null && finger.next.data != someValue)
                    finger = finger.next;

                if (finger.next != null)//if found
                    //finger stops right before the node we want to delete
                    finger.next = finger.next.next;
                else
                    Console.WriteLine("value no found");
            }
        }
        //ctor
        public SinlgyLinkedList()
        {
            head = null;
        }
    }
}
*/