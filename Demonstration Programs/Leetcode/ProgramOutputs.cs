using System;

namespace Leetcode
{
    class ProgramOutputs
    {
        static void Main(string[] args)
        {
            // LinkedListCycle.........

            LinkedListCycle newlist = new LinkedListCycle();
            newlist.AddFront(1);
            newlist.AddFront(2);
            newlist.AddFront(3);
            newlist.AddFront(4);
            newlist.HasCycle();
            newlist.head.next.next.next.next = newlist.head;
            newlist.HasCycle();
            
        }
    }
}
