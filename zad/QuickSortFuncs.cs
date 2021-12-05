using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace zad
{
    public class QuickSortFuncs
    {
        public static void quickSort1(ref int[] tab, int indexLow, int indexHigh)
        {
            try
            {
                if (indexLow >= indexHigh || indexLow < 0 || indexHigh < 0)
                {
                    return;
                }

                int pivot = tab[indexLow];

                int lowerNumbersEndIndex = indexLow + 1;

                for (int iterator = indexLow + 1; iterator <= indexHigh; iterator++)
                {

                    if (tab[iterator] <= pivot)
                    {
                        (tab[lowerNumbersEndIndex], tab[iterator]) = (tab[iterator], tab[lowerNumbersEndIndex]);
                        lowerNumbersEndIndex++;
                    }
                }

                (tab[indexLow], tab[lowerNumbersEndIndex - 1]) = (tab[lowerNumbersEndIndex - 1], tab[indexLow]);

                quickSort1(ref tab, indexLow, lowerNumbersEndIndex - 2);
                quickSort1(ref tab, lowerNumbersEndIndex, indexHigh);
            }
            catch (Exception r) { }

        }
        public static void quickSort2(ref int[] tab, int left, int right)
        {
            int i = left;
            int j = right;
            int x = tab[(left + right) / 2];
            do
            {
                while (tab[i] < x)
                    i++;

                while (tab[j] > x)
                    j--;

                if (i <= j)
                {
                    (tab[i], tab[j]) = (tab[j], tab[i]);

                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j) quickSort2(ref tab, left, j);

            if (right > i) quickSort2(ref tab, i, right);

        }
        public static void quickSort3(int lewy, int prawy, ref int[] d)
        {
            int i, j, piwot;

            i = (lewy + prawy) / 2;
            piwot = d[i];
            d[i] = d[prawy];
            for (j = i = lewy; i < prawy; i++)
                if (d[i] < piwot)
                {
                    (d[i], d[j]) = (d[j], d[i]);
                    j++;
                }
            d[prawy] = d[j];
            d[j] = piwot;

            if (lewy < j - 1) quickSort3(lewy, j - 1, ref d);
            if (j + 1 < prawy) quickSort3(j + 1, prawy, ref d);
        }

    }
}