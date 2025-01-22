using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Project.Utilities
{
    internal class MemoryProfiler
    {
        public static long MeasureMemory(Action sortingAction, List<int> data)
        {
            // Veri boyutunu hesapla
            long dataMemory = CalculateDataMemory(data);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            long initialMemory = GC.GetTotalMemory(true);

            sortingAction();

            long finalMemory = GC.GetTotalMemory(false);

            // Değişen bellek miktarını hesapla
            long usedMemory = finalMemory - initialMemory;
            // Toplam bellek: veri boyutu + değişen bellek
            return dataMemory + (usedMemory > 0 ? usedMemory : 0);
        }

        private static long CalculateDataMemory<T>(List<T> data)
        {
            // Listenin tahmini bellek boyutunu hesaplar
            if (data == null || data.Count == 0)
                return 0;

            long sizeOfElement = GetSizeOfElement(data[0]);
            return sizeOfElement * data.Count;
        }

        private static long GetSizeOfElement<T>(T element)
        {
            // Bir nesnenin tahmini boyutunu al
            if (element is int) return sizeof(int);
            if (element is long) return sizeof(long);

            // Daha karmaşık nesneler için tahmini değer
            return 32; // Varsayılan tahmin
        }
    }
}
