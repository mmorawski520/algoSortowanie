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
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < size; i++)
                for (int j = 1; j < size - i; j++)
                    if (tab[j - 1] > tab[j])
                        (tab[j - 1], tab[j]) = (tab[j], tab[j - 1]);

            stopwatch.Stop();
            sortedArray = tab;

            return stopwatch.ElapsedMilliseconds.ToString();
        }
        public static string bubbleSort2(int[] tab, int size, ref int[] sortedArray)
        {
            int i, j;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (j = size - 1; j > 0; j--)
                for (i = 0; i < j; i++)
                    if (tab[i] > tab[i + 1])
                    {
                        (tab[i], tab[i + 1]) = (tab[i + 1], tab[i]);
                    }
            stopwatch.Stop();
            sortedArray = tab;

            return stopwatch.ElapsedMilliseconds.ToString();
        }
        public static string bubbleSort3(int[] tab, int N, ref int[] sortedArray)
        {
            int pmin, pmax, p, i;
            pmin = 0;
            pmax = N - 1;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
           

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

            stopwatch.Stop();
            sortedArray = tab;
            return stopwatch.ElapsedMilliseconds.ToString();
         
        }
    }
}