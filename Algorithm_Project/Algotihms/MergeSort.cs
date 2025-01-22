using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Project.Algotihms
{
    internal class MergeSort
    {
        public static void Sort(List<int> data)
        {
            if (data.Count <= 1) return;

            int mid = data.Count / 2;
            var left = data.Take(mid).ToList();
            var right = data.Skip(mid).ToList();

            Sort(left);
            Sort(right);

            Merge(data, left, right);
        }

        private static void Merge(List<int> data, List<int> left, List<int> right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Count && j < right.Count)
                data[k++] = (left[i] < right[j]) ? left[i++] : right[j++];

            while (i < left.Count)
                data[k++] = left[i++];

            while (j < right.Count)
                data[k++] = right[j++];
        }
    }
}
