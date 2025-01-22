using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Project.Utilities
{
    internal class DataGenerator
    {
        public static List<int> GenerateData(int size, string type)
        {
            Random rand = new Random();
            List<int> data = Enumerable.Range(1, size).ToList();

            switch (type)
            {
                case "Random":
                    data = data.OrderBy(x => rand.Next()).ToList();
                    break;
                case "Partially Sorted":
                    data = data.OrderBy(x => rand.Next(size / 10)).ToList();
                    break;
                case "Reverse":
                    data.Reverse();
                    break;
            }

            return data;
        }
    }
}
