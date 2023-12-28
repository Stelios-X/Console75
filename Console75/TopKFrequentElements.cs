using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k) 
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            //Count the frequency of each element
            foreach (int num in nums) 
            {
                if (!frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num] = 1;
                }
                else 
                {
                    frequencyMap[num]++;
                }
            }

            //Use a min heap to keep track of the top k frequent elements
            PriorityQueue<int> minHeap = new PriorityQueue<int>((a,b) => frequencyMap[a] - frequencyMap[b]);

            foreach (int num in frequencyMap.Keys)
            {
                minHeap.Enqueue(num);

                //Remove the least frequent element if the heap size exceeds k
                if (minHeap.Count > k) 
                {
                    minHeap.Dequeue();
                }
            }

            //Convert the heap to an array and reverse the order
            int[] result = new int[k];
            for (int i = k - 1; i >= 0; i-- ) 
            {
                result[i] = minHeap.Dequeue();
            }
            return result;
        }
    }
}
