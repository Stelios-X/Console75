using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class LinkedListCycle
    {
        /*
         *Time ComplexityO(n) , where n is the number of nodes in the linked list. 
         *This is because in the worst-case scenario, we will visit each node once.
         *Space Complexity O(1), as we are only using a constant amount of space to store our two pointers.
         * 
         * 
         *  Given a linked list, determine if it has a cycle in it. A cycle in a linked list means that some node in 
         *  the list can be reached again by continuously following the next pointer.
         *  
         *  We can solve this problem using Floyd’s cycle-finding algorithm, also known as the “tortoise and the hare” algorithm. 
         *  This algorithm uses two pointers, one that moves two steps at a time (the hare), 
         *  and another that moves one step at a time (the tortoise). If there is a cycle in the list, 
         *  the hare will eventually meet the tortoise.
         */


        public bool LinkedListCycleSol(ListNoder head) 
        {
            //If the list is empty or has only one node, it lacks a cycle
            if (head == null || head.next == null) 
            {
                return false;
            }

            //Initialize the 2 pointers
            ListNoder slow = head;
            ListNoder fast = head.next;

            //Until the two pointers meet or we find the end of the list
            while (slow != fast) 
            {
                //If we've found the end of the list, it doesn't have a cycle
                if (fast == null || fast.next == null ) 
                {
                    return false;
                }

                //Move the pointers
                slow = slow.next;   
                fast = fast.next.next;
            }
            //If the two pointers met, the list has a cycle
            return true;

        }
    }
}
