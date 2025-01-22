using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Project.Algotihms
{
    internal class RadixSort
    {
        public static void Sort(List<int> data)
        {
            int max = data.Max();
            int exp = 1;

            while (max / exp > 0)
            {
                CountingSort(data, exp);
                exp *= 10;
            }
        }

        private static void CountingSort(List<int> data, int exp)
        {
            int n = data.Count;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
                count[(data[i] / exp) % 10]++;

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(data[i] / exp) % 10] - 1] = data[i];
                count[(data[i] / exp) % 10]--;
            }

            for (int i = 0; i < n; i++)
                data[i] = output[i];
        }
    }
}
