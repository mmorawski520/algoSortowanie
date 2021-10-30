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
       public static string sorting1(int[] tab, int size,ref int[] sortedArray)
        {
            int temp, j;
            var stopwatch = new Stopwatch();
            long start = Stopwatch.GetTimestamp();


            for (int i = 1; i < size; i++)
            {
                temp = tab[i];

                for (j = i - 1; j >= 0 && tab[j] > temp; j--)
                    tab[j + 1] = tab[j];

                tab[j + 1] = temp;
            }
            long end = Stopwatch.GetTimestamp();
            sortedArray = tab;
            return (end - start).ToString("");
            //Double elapsedMillisecs = ((TimeSpan)(end - start)).TotalMilliseconds;
            // return (koniec - start).TotalMilliseconds.ToString();

        }

        public static  string sorting2(int[] tab, int n, ref int[] sortedArray)
        {
            int pom, j;
            var stopwatch = new Stopwatch();
            long start = Stopwatch.GetTimestamp();


            for (int i = 1; i < n; i++)
            {
                //wstawienie elementu w odpowiednie miejsce
                pom = tab[i]; //ten element będzie wstawiony w odpowiednie miejsce
                j = i - 1;

                //przesuwanie elementów większych od pom

                while (j >= 0 && tab[j] > pom)
                {
                    tab[j + 1] = tab[j]; //przesuwanie elementów
                    --j;
                }
                tab[j + 1] = pom; //wstawienie pom w odpowiednie miejsce
            }
        
            var koniec = DateTime.Now;
            sortedArray = tab;
            long end = Stopwatch.GetTimestamp();
            return (end - start).ToString();
        }

       public static string sorting3(int[] d, int N, ref int[] sortedArray)
        {
            int j, i, x;

            var stopwatch = new Stopwatch();
            long start = Stopwatch.GetTimestamp();

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
            long end = Stopwatch.GetTimestamp();
            sortedArray = d;
            return (end - start).ToString();
           // return (koniec - start).TotalMilliseconds.ToString();
            //  label2.Text = label2.Text = (koniec - start).TotalMilliseconds.ToString();
        }
    }
}
