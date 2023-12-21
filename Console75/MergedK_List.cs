using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MergedK_List
    {
        /*
         * Time Complexity O(Nlogk) where N is the total number of nodes in all the lists and k is the number of lists. 
         * This is because we insert each node into the heap exactly once and each insertion operation takes logk time.
         * Space Complexity O(k) because at any point in time, the heap will hold at most k nodes.
         * 
         * Given an array of k linked-lists lists, each linked-list is sorted in ascending order. 
         * Merge all the linked-lists into one sorted linked-list and return it.
         * 
         * We can solve this problem using a priority queue (Min Heap). The heap will always have the smallest node (head of a list)
         * at the top. We pop the smallest node from the heap, add it to the result, and then push the next node from 
         * the same list into the heap. We repeat this process until the heap is empty.
         * 
         */


        public ListNoder MergedK_ListSol(ListNoder[] lists) 
        {
            //Create a new 'dummy' node to serve as the start of the result list
            ListNoder dummy = new ListNoder(0);
            ListNoder tail = dummy;

            //Create a priority queue and add the first node to each list
            SortedSet<(ListNoder node, int index)> pq = new 
                SortedSet<(ListNoder node, int index)>(Comparer<(ListNoder node, int index)>
                .Create((x,y) => x.node.val != y.node.val ? x.node.val.CompareTo(y.node.val) : x.index.CompareTo(y.index)));

            for (int i = 0; i < lists.Length; i++) 
            {
                if (lists[i] != null) 
                {
                    pq.Add((lists[i], i));
                    lists[i] = lists[i].next;
                }
            }
            //while the priority queue is not empty
            while (pq.Count > 0) 
            {
                //Pop the smallest node and add it to the result list
                (ListNoder node,int index) = pq.Min();
                pq.Remove(pq.Min);
                tail.next = node;
                tail = node;

                //Push the next node from the same list into the priority queue
                if (lists[index] != null) 
                {
                    pq.Add((lists[index], index));
                    lists[index] = lists[index].next;
                }

            }
            return dummy.next;
        }
    }
}
