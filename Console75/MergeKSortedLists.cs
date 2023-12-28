using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MergeKSortedLists
    {
        /*
         * Time Complexity O(N * log(k)), where N is the total number of nodes and k is the number of linked lists.
         * 
         * Space Complexity O(1) as the merging is done in-place without using extra space.
         * 
         * You are given an array of k linked-lists, each linked-list is sorted in ascending order. Merge all the linked-lists into 
         * one sorted linked-list and return it.
         * 
         * The code uses a divide-and-conquer strategy to merge the linked lists in pairs until there is only one list remaining.
           The MergeTwoLists method merges two sorted linked lists.
           The MergeKLists method repeatedly merges pairs of linked lists until only one list remains.
           The examples demonstrate the usage of the MergeKSortedLists class with different arrays of linked lists.
         */

        public ListNode MergeKLists(ListNode[] lists) 
        {
            if (lists == null || lists.Length == 0) 
            {
                return null;
            }

            int k = lists.Length;
            while (k > 1) 
            {
                int newK = (k + 1)/2; //The number of merged lists
                for (int i = 0; i < k/2; i++) 
                {
                    lists[i] = MergeTwoLists(lists[i], lists[i + k/2]);
                }
                k = newK;
            }
            return lists[0];
        }
        private ListNode MergeTwoLists(ListNode l1, ListNode l2) 
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (l1 != null && l2 != null) 
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else 
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }
            //Attach the remaining nodes from either list
            if (l1 != null)
            {
                current.next = l1;
            }
            else 
            {
                current.next = l2;
            }
            return dummy.next;
        }
    }
}
