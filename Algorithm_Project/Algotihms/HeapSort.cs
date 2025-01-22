using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Project.Algotihms
{
    internal class HeapSort
    {
        public static void Sort(List<int> data)
        {
            int n = data.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(data, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                (data[0], data[i]) = (data[i], data[0]);
                Heapify(data, i, 0);
            }
        }

        private static void Heapify(List<int> data, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && data[left] > data[largest])
                largest = left;

            if (right < n && data[right] > data[largest])
                largest = right;

            if (largest != i)
            {
                (data[i], data[largest]) = (data[largest], data[i]);
                Heapify(data, n, largest);
            }
        }
    }
}
