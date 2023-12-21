using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class RecorderList
    {
        /*
         * Time Complexity O(n) because we make three passes through the list.
         * Space Complexity O(1) because we only use a constant amount of space to store pointers.
         * 
         * The problem is to reorder a singly linked list such that the nodes from the second half of the singly linked list 
         * are inserted alternately to the nodes from the first half. 
         * 
         * Find the middle of the list: We can do this by using the two-pointer technique where one pointer moves two steps at a time
         * and the other moves one step. When the fast pointer reaches the end, the slow pointer will be at the middle.
            
            Reverse the second half of the list: We can reverse the list from the middle to the end using a simple iterative method.

            Merge the two halves of the list: We can then merge the two halves of the list by alternating nodes from each half.
         */

        public void RecorderListSol(ListNode head) 
        {
            if (head == null || head.next == null) 
            {
                return;
            }

            //Step 1: Find the middle of the list
            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null) 
            {
                slow = fast.next;
                fast = fast.next.next;
            }

            //Step 2: Reverse the second half of the list
            ListNode prev = null;
            ListNode curr = slow.next;
            while (curr != null) 
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp; 
            }
            slow.next = null;

            //Step 3: Merge the two halves of the list
            ListNode first = head; 
            ListNode second = prev;
            while (second != null) 
            {
                ListNode nextTemp = first.next;
                first.next = second;
                first = second;
                second = nextTemp;
            }
        }
    }
}
