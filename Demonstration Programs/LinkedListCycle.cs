
/// <summary>
/// SOURCE: https://leetcode.com/problems/linked-list-cycle/
/// 
/// STUDENT: Brandon Crandall
/// 
/// SYNOPSIS: Given a linked list, determine if it has a cycle in it.
/// </summary>

namespace Demonstration_Programs
{
    public class LinkedListCycle
    {
        //Creating a method to add values to a linkedlist
        ListNode head;
        public void AddFront(int Value)
        {
            ListNode newNode = new ListNode(Value);

            newNode.next = head;

            head = newNode;
        }

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
                    return true;
                }
            }
            return false;
        }

        //Creating a node of a linked list
        private class ListNode
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

    }
}

