using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class RemoveN_Node
    {
        /*
         * Time Complexity O(L) where L is the number of nodes in the list. This is because we traverse the list with two pointers.
         * Space Complexity O(1) as we are only using a constant amount of space to store our pointers.
         * 
         * Given a linked list, remove the n-th node from the end of the list and return its head.
         * 
         *
         *We can solve this problem using a two-pointer approach. We maintain two pointers, first and second, 
         *where first is n nodes ahead of second. When first reaches the end, second will be at the (n+1)-th node from the end.
         *We then remove the n-th node by skipping it in the list.
         */

        public ListNoder RemoveN_NodeSol(ListNoder head, int n) 
        {
            //Create a new 'dummy' node to serve as the stary of the list
            ListNoder dummy = new ListNoder(0);
            dummy.next = head;  

            //Initialize the two points
            ListNoder first = dummy;    
            ListNoder second = dummy;

            //Move the first pointer so that the gap between first and second is n nodes apart
            for (int i = 1; i < n + 1; i++) 
            {
                first = first.next; 
            }

            //Move first to the end, maintaining the gap
            while (first != null) 
            {
                first = first.next; 
                second = second.next;
            }

            //Skip the n-th node from the end
            second.next = second.next.next;

            return dummy.next;
        }


    }
}
