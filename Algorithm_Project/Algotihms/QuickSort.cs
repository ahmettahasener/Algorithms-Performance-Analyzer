using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Project.Algotihms
{
    internal class QuickSort
    {
        public static void Sort(List<int> data)
        {
            SortHelper(data, 0, data.Count - 1);
        }

        private static void SortHelper(List<int> data, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(data, low, high);
                SortHelper(data, low, pivotIndex - 1);
                SortHelper(data, pivotIndex + 1, high);
            }
        }

        private static int Partition(List<int> data, int low, int high)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(low, high + 1);
            (data[randomIndex], data[high]) = (data[high], data[randomIndex]);

            int pivot = data[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (data[j] <= pivot)
                {
                    i++;
                    (data[i], data[j]) = (data[j], data[i]);
                }
            }

            (data[i + 1], data[high]) = (data[high], data[i + 1]);
            return i + 1;
        }
    }
}
