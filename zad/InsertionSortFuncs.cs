using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace zad
{
    public class InsertionSort
    {
        public static string insertionSort1(int[] tab, int size, ref int[] sortedArray)
        {
            int temp, j;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i < size; i++)
            {
                temp = tab[i];

                for (j = i - 1; j >= 0 && tab[j] > temp; j--)
                    tab[j + 1] = tab[j];

                tab[j + 1] = temp;
            }
            stopwatch.Stop();
            sortedArray = tab;
            return stopwatch.ElapsedMilliseconds.ToString();

        }

        public static string insertionSort2(int[] tab, int n, ref int[] sortedArray)
        {
            int pom, j;
         
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i < n; i++)
            {
                pom = tab[i];
                j = i - 1;

                while (j >= 0 && tab[j] > pom)
                {
                    tab[j + 1] = tab[j];
                    --j;
                }
                tab[j + 1] = pom;
            }

            stopwatch.Stop();
            sortedArray = tab;
            return stopwatch.ElapsedMilliseconds.ToString();
        }

        public static string insertionSort3(int[] d, int N, ref int[] sortedArray)
        {
            int j, i, x;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (j = N - 2; j >= 0; j--)
            {
                x = d[j];
                i = j + 1;
                while ((i < N) && (x > d[i]))
                {
                    d[i - 1] = d[i];
                    i++;
                }
                d[i - 1] = x;
            }

            stopwatch.Stop();
            sortedArray = d;
            return stopwatch.ElapsedMilliseconds.ToString();
        }
    }
}