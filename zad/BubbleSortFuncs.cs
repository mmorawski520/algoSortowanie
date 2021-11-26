using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace zad
{
    class bubbleSortFuncs
    {
        public static string bubbleSort(int[] tab, int size, ref int[] sortedArray)
        {
            long start = Stopwatch.GetTimestamp();

            for (int i = 0; i < size; i++)
                for (int j = 1; j < size - i; j++)
                    if (tab[j - 1] > tab[j])

                        (tab[j - 1], tab[j]) = (tab[j], tab[j - 1]);

            long end = Stopwatch.GetTimestamp();
            sortedArray = tab;

            return (end - start).ToString("");

        }
        public static string bubbleSort2(int[] tab, int size, ref int[] sortedArray)
        {
            int i, j;
            long start = Stopwatch.GetTimestamp();
            for (j = size - 1; j > 0; j--)
                for (i = 0; i < j; i++)
                    if (tab[i] > tab[i + 1])
                    {
                        (tab[i], tab[i + 1]) = (tab[i + 1], tab[i]);
                    }

            long end = Stopwatch.GetTimestamp();
            sortedArray = tab;

            return (end - start).ToString("");
        }
        public static string bubbleSort3(int[] tab, int N, ref int[] sortedArray)
        {
            int pmin, pmax, p, i;
            pmin = 0;
            pmax = N - 1;
            long start = Stopwatch.GetTimestamp();
            do
            {
                p = -1;
                for (i = pmin; i < pmax; i++)
                    if (tab[i] > tab[i + 1])
                    {
                        (tab[i], tab[i + 1]) = (tab[i + 1], tab[i]);
                        if (p < 0) pmin = i;
                        p = i;
                    }
                if (pmin != null) pmin--;
                pmax = p;
            } while (p >= 0);

            long end = Stopwatch.GetTimestamp();
            sortedArray = tab;

            return (end - start).ToString("");
        }
    }
}