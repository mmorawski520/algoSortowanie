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
        public static void bubbleSort(int[] tab, int size, ref int[] sortedArray)
        {

            for (int i = 0; i < size; i++)
                for (int j = 1; j < size - i; j++)
                    if (tab[j - 1] > tab[j])
                        (tab[j - 1], tab[j]) = (tab[j], tab[j - 1]);

            sortedArray = tab;

        }
        public static void bubbleSort2(int[] tab, int size, ref int[] sortedArray)
        {
            int i, j;
            var stopwatch = new Stopwatch();

            for (j = size - 1; j > 0; j--)
                for (i = 0; i < j; i++)
                    if (tab[i] > tab[i + 1])
                    {
                        (tab[i], tab[i + 1]) = (tab[i + 1], tab[i]);
                    }

            sortedArray = tab;

        }
        public static void bubbleSort3(int[] intArray, int numLength, ref int[] sortedArray)
        {

            int count = 0;

            for (int j = 0; j <= numLength - 2; j++)
            {

                for (int i = 0; i <= numLength - 2; i++)
                {
                    count = count + 1;
                    if (intArray[i] > intArray[i + 1])
                    {
                        int temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }

            sortedArray = intArray;

        }
    }
}