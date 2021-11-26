using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace zad
{
    public static class HeapSortFuncs
    {
        //==============================

        public static void heapify3(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            if (l < n && arr[l] > arr[largest])
                largest = l;
            if (r < n && arr[r] > arr[largest])
                largest = r;
            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                heapify3(arr, n, largest);
            }
        }
        public static void sort3(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);
                heapify3(arr, i, 0);
            }
        }
        ///==============================
        public static void heapify2(int[] tab, int heap_size, int i)
        {

            int largest, temp;
            int l = 2 * i, r = (2 * i) + 1;
            if (l <= heap_size && tab[l] > tab[i])
                largest = l;
            else largest = i;
            if (r <= heap_size && tab[r] > tab[largest])
                largest = r;
            if (largest != i)
            {
                temp = tab[largest];
                tab[largest] = tab[i];
                tab[i] = temp;
                heapify2(tab, heap_size, largest);
            }
        }

        public static void budKopiec(int[] tab, int rozmiar)
        {
            for (int i = rozmiar / 2; i > 0; i--)
                heapify2(tab, rozmiar, i);
        }

        public static void sort1(int[] tab, int rozmiar)
        {
            int temp;
            budKopiec(tab, rozmiar);
            for (int i = rozmiar; i > 1; i--)
            {
                temp = tab[i];
                tab[i] = tab[1];
                tab[1] = temp;
                rozmiar--;
                heapify2(tab, rozmiar, 1);
            }
        }
        public static void sort2(int[] arr, int n)
        {
            // Build max heap
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // Heap sort
            for (int i = n - 1; i >= 0; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);

                // Heapify root element to get highest element at root again
                heapify(arr, i, 0);
            }
        }
        ///==========================
        public static void heapify(int[] arr, int n, int i)
        {
            // Find largest among root, left child and right child
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            // Swap and continue heapifying if root is not largest
            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                heapify(arr, n, largest);
            }
        }

        // main function to do heap sort
        public static void sort(int[] arr, int n)
        {
            // Build max heap
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // Heap sort
            for (int i = n - 1; i >= 0; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);

                // Heapify root element to get highest element at root again
                heapify(arr, i, 0);
            }
        }
        /*
         * for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // Heap sort
            for (int i = n - 1; i >= 0; i--)
            {
                (arr[0], arr[i])=(arr[i],arr[0]);

                // Heapify root element to get highest element at root again
                heapify(arr, i, 0);
            }*/
        public static string heapSort3(int[] arr, int n)
        {
            long start = Stopwatch.GetTimestamp();
            sort3(arr, arr.Length - 1);
            long end = Stopwatch.GetTimestamp();
            return (end - start).ToString();
        }
        public static string heapSort2(int[] arr, int n)
        {
            long start = Stopwatch.GetTimestamp();
            sort2(arr, arr.Length - 1);
            long end = Stopwatch.GetTimestamp();
            return (end - start).ToString();
        }
        public static string heapSort1(int[] arr, int n)
        {
            long start = Stopwatch.GetTimestamp();
            sort1(arr, arr.Length - 1);
            long end = Stopwatch.GetTimestamp();
            return (end - start).ToString();
        }

    }
}

