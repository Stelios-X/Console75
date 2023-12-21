using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MergeTwoLists
    {
        /*
         * Time ComplexityO(n+m) where n and m are the lengths of the two lists. 
         * This is because in the worst-case scenario, we will visit each node in both lists once.
         * Space Complexity O(n+m) because the depth of the recursion stack can go up to n+m
         * 
         * Given two sorted linked lists, merge them in such a way that the resulting linked list is also sorted.
         * 
         * We can solve this problem using a recursive approach. We compare the values of the nodes of the two lists and recursively
         * merge the remaining elements.
         * 
         */

        public ListNoder MergeTwoListsSol(ListNoder l1, ListNoder l2) 
        {
            //If either of the lists is null, return the other list
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val < l2.val)
            {
                //If the value of l1 is less than that of l2, set the next of l1 to be the result of a recusive call
                //with the next of l1 & l2 
                return l1;

            }
            else 
            {
                //If the value of l2 is less than or eqaul to l1, set the next of l2 to be the result of a recusive call with
                //l1 and the next of l2

                l2.next = MergeTwoListsSol(l1, l2.next);
                return l2;
            }

        }
    }
}
