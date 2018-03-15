using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Program
    {
        public static int Partition(int[] array, int first, int last)
        {
            int buff;
            int marker = first;
            for (int i = first; i <= last; i++)
            {
                if (array[i] < array[last])
                {
                    buff = array[marker];
                    array[marker] = array[i];
                    array[i] = buff;
                    marker += 1;
                }
            }
            buff = array[marker];
            array[marker] = array[last];
            array[last] = buff;
            return marker;
        }
        public static void QuickSort(int[] array, int first, int last)
        {
            if (first >= last)
            {
                return;
            }
            int partingElement = Partition(array, first, last);
            QuickSort(array, first, partingElement - 1);
            QuickSort(array, partingElement + 1, last);
        }
        static void Main(string[] args)
        {

        }
    }
}
