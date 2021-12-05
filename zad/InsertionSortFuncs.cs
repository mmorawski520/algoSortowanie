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
        public static void insertionSort1(int[] a, int s, ref int[] sortedArray)
        {

            for (int i = 0; i < s - 1; i++)
            {
                int j = i + 1;
                int key = a[j];
                while (i >= 0 && a[i] > key)
                {
                    a[i + 1] = a[i];
                    i--;
                }
                a[i + 1] = key;
            }

            sortedArray = a;

        }

        public static void insertionSort2(int[] tab, int n, ref int[] sortedArray)
        {
            int pom, j;

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

            sortedArray = tab;

        }

        public static void insertionSort3(int[] d, int N, ref int[] sortedArray)
        {
            int j, i, x;

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

            sortedArray = d;

        }
    }
}