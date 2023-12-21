using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ReverseList
    {
        /*
         * Time Complexity O(n), where n is the number of nodes in the list. This is because we process each node once.
         * Space Complexity O(1), as we only use a constant amount of space.
         * 
         * 
         * Given the head of a singly linked list, reverse the list, and return the reversed list.
         * 
         * 
         * The idea is to initialize three pointers: prev as null, curr as head, and next. Then, in a loop, set next to be 
         * the next node of curr, change the next node of curr to prev, and move prev and curr one step forward.
         
         
         
         */

        public ListNode ReverseListSol(ListNode head) 
        {
            ListNode prev = null;
            ListNode curr = head;

            // Iterate through the list, reversing pointers
            while (curr != null) 
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            // The new head of the reversed list
            return prev;
        }
    }
}
