using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class PriorityQueue<T>
    {
        private List<T> heap;
        private Comparison<T> comparer;

        public int Count 
        {
            get { return heap.Count; } 
        }

        public PriorityQueue(Comparison<T> comparer) 
        {
            this.heap = new List<T>();
            this.comparer = comparer;
        }

        public void Enqueue(T item) 
        {
            heap.Add(item);
            int index = heap.Count - 1;
            while (index > 0) 
            {
                int parentIndex = (index - 1)/2;
                if (comparer(heap[index], heap[parentIndex]) < 0)
                {
                    Swap(index, parentIndex);
                    index = parentIndex;
                }
                else 
                {
                    break;
                }
            }
        }

        public T Dequeue() 
        {
            if (heap.Count == 0) 
            {
                throw new InvalidOperationException("Priority queue is empty");
            }

            T item = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            int index = 0;
            while (true) 
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;
                int smallest = index;

                if (leftChild < heap.Count && comparer(heap[leftChild], heap[smallest]) < 0) 
                {
                    smallest = leftChild;
                }
                if (rightChild < heap.Count && comparer(heap[rightChild], heap[smallest]) < 0)
                {
                    smallest = rightChild;
                }

                if (smallest != index)
                {
                    Swap(index, smallest);
                }
                else 
                {
                    break;
                }
            }
            return item;
        }
        private void Swap(int i, int j) 
        {
            T temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}
