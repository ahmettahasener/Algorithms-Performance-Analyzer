using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Project.Algotihms
{
    internal class ShellSort
    {
        public static void Sort(List<int> data)
        {
            int n = data.Count;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = data[i];
                    int j;

                    for (j = i; j >= gap && data[j - gap] > temp; j -= gap)
                    {
                        data[j] = data[j - gap];
                    }

                    data[j] = temp;
                }
            }
        }
    }
}
