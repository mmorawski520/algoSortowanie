using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace zad
{

    public static class MergeSortFuncs
    {
        public static void merge1(int[] arr, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int i, j, k;
            int[] L = new int[n1];
            int[] M = new int[n2];

            for (int z = 0; z < n1; z++)
                L[z] = arr[p + z];
            for (int x = 0; x < n2; x++)
                M[x] = arr[q + 1 + x];

            i = 0;
            j = 0;
            k = p;

            while (i < n1 && j < n2)
            {
                if (L[i] <= M[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = M[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = M[j];
                j++;
                k++;
            }
        }

        public static void merge2(int[] array, int l, int m, int r)
        {
            int i, j, k, nl, nr;

            nl = m - l + 1;
            nr = r - m;

            int[] larr = new int[nl];
            int[] rarr = new int[nr];

            for (i = 0; i < nl; i++)
                larr[i] = array[l + i];
            for (j = 0; j < nr; j++)
                rarr[j] = array[m + 1 + j];

            i = 0;
            j = 0;
            k = l;

            while (i < nl && j < nr)
            {
                if (larr[i] <= rarr[j])
                {
                    array[k] = larr[i];
                    i++;
                }
                else
                {
                    array[k] = rarr[j];
                    j++;
                }
                k++;
            }
            while (i < nl)
            {
                array[k] = larr[i];
                i++;
                k++;
            }
            while (j < nr)
            {
                array[k] = rarr[j];
                j++;
                k++;
            }
        }
        public static void merge3(int[] tablica, int start, int srodek, int koniec)
        {
            int[] tab_pom = new int[(koniec - start) + 1]; 
            int i = start, j = srodek + 1, k = 0; 

            while (i <= srodek && j <= koniec)
            {
                if (tablica[j] < tablica[i])
                {
                    tab_pom[k] = tablica[j];
                    j++;
                }
                else
                {
                    tab_pom[k] = tablica[i];
                    i++;
                }
                k++;
            }

            if (i <= srodek)
            {
                while (i <= srodek)
                {

                    tab_pom[k] = tablica[i];
                    i++;
                    k++;
                }
            }
            else
            {
                while (j <= koniec)
                {
                    tab_pom[k] = tablica[j];
                    j++;
                    k++;
                }
            }

            for (i = 0; i <= koniec - start; i++)
                tablica[start + i] = tab_pom[i];
        }

        public static void sort1(int[] arr, int l, int r)
        {
            if (l < r)
            {

                int m = l + (r - l) / 2;

                sort1(arr, l, m);
                sort1(arr, m + 1, r);
                merge1(arr, l, m, r);
            }
        }
        public static void sort2(int[] array, int l, int r)
        {

            if (l < r)
            {
                var m = l + (r - l) / 2;
                sort2(array, l, m);
                sort2(array, m + 1, r);

            }
        }
        public static void sort3(int[] tablica, int start, int koniec)
        {
            int srodek;

            if (start != koniec)
            {
                srodek = (start + koniec) / 2;

                sort3(tablica, start, srodek);
                sort3(tablica, srodek + 1, koniec);
                merge3(tablica, start, srodek, koniec);
            }
        }

        public static string mergeSort1(int[] arr, int l, int r, ref int[] sortedArray)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            sort1(arr, l, r);
            stopwatch.Stop();
            sortedArray = arr;
            return stopwatch.ElapsedMilliseconds.ToString();
        }
        public static string mergeSort2(int[] array, int l, int r, ref int[] sortedArray)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            sort2(array, l, r);
            stopwatch.Stop();
            sortedArray = array;
            return stopwatch.ElapsedMilliseconds.ToString();

        }

        public static string mergeSort3(int[] tablica, int start, int koniec, ref int[] sortedArray)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            sort3(tablica, start, koniec);

            stopwatch.Stop();
            sortedArray = tablica;
           
            
            return stopwatch.ElapsedMilliseconds.ToString();
             
           
        }

    }
}