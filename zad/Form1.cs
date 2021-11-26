using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace zad
{
    public partial class Form1 : Form
    {   
        //Ta zmienna przechowuje wczytana tablice przekazuje ja do funkcji/metod i nie zmieniam jej wartosci
        int[]tempArray;
        //Ta zmienna przechowuje posortowana tablice przekazuje ja do funkcji/metod aby zmienic jej wartosc
        int[] sortedArray;
        
        public Form1()
        {
            InitializeComponent();
        }
        void merge3(int[] tablica, int start, int srodek, int koniec)
        {
            int[] tab_pom = new int[(koniec - start)+1]; // utworzenie tablicy pomocniczej
            int i = start, j = srodek + 1, k = 0; // zmienne pomocnicze

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

                    tab_pom[k] =tablica[i];
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
       
        
        void merge_sort3(int[] tablica, int start, int koniec)
        {
            int srodek;

            if (start != koniec)
            {
                srodek = (start + koniec) / 2;
           
                merge_sort3(tablica, start, srodek);
                merge_sort3(tablica, srodek + 1, koniec);
                merge3(tablica, start, srodek, koniec);
            }
        }

        ///============================================
        void merge2(int[] array, int l, int m, int r)
        {
            int i, j, k, nl, nr;
            //size of left and right sub-arrays
            nl = m - l + 1; nr = r - m;
            //intp larr[nl], rarr[nr];
            int[] larr = new int[nl];
            int[] rarr = new int[nr];
            //fill left and right sub-arrays
            for (i = 0; i < nl; i++)
                larr[i] = array[l + i];
            for (j = 0; j < nr; j++)
                rarr[j] = array[m + 1 + j];
            i = 0; j = 0; k = l;
            //marge temp arrays to real array
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
            {       //extra element in left array
                array[k] = larr[i];
                i++; k++;
            }
            while (j < nr)
            {     //extra element in right array
                array[k] = rarr[j];
                j++; k++;
            }
        }
        void mergeSort2(int[] array, int l, int r)
        {
             
            if (l < r)
            {
                var m = l + (r - l) / 2;
                // Sort first and second arrays
                mergeSort2(array, l, m);
                mergeSort2(array, m + 1, r);
                merge2(array, l, m, r);
            }
        }
        ///==========================
        void merge(int[] arr, int p, int q, int r)
        {

            // Create L ← A[p..q] and M ← A[q+1..r]
            int n1 = q - p + 1;
            int n2 = r - q;
            int i, j, k;
            //int L[n1], M[n2];
            int[] L = new int[n1];
            int[] M = new int[n2];
            for (int z = 0; z < n1; z++)
                L[z] = arr[p + z];
            for (int x = 0; x < n2; x++)
                M[x] = arr[q + 1 + x];

            // Maintain current index of sub-arrays and main array
            
            i = 0;
            j = 0;
            k = p;

            // Until we reach either end of either L or M, pick larger among
            // elements L and M and place them in the correct position at A[p..r]
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

            // When we run out of elements in either L or M,
            // pick up the remaining elements and put in A[p..r]
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
        void mergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // m is the point where the array is divided into two subarrays
                int m = l + (r - l) / 2;

                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);

                // Merge the sorted subarrays
                merge(arr, l, m, r);
            }
        }



        //ten void wczytuje dane z pliku wybranego przez uzytkownika
        void loading()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;

                    int i = 0;
                    string ln;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {

                        var counter = 0;
                        tempArray = new int[File.ReadLines(filePath).Count()];
                        foreach (string line in File.ReadLines(filePath))
                        {

                            tempArray[counter] = Int32.Parse(line);
                            counter++;
                        }
                    }
                }
                labelChoosenFile.Text = "Choosen file : " + filePath;
            }
        }
        
        /* Przyciski do sortowania przez wstawianie 
         Funkcje do sortowania znajduja sie w odzielnym w pliku i specjalnej klasie
         jako argumenty trzeba podac nieposortowana tablice, dlugosc tej tablicy, oryginalna tablice sorted array
         wartosc sortedArray ulegnie zmianie poprzez referencje
          
        Funkcje do sortowania zwracaja stringa z czasem poswieconym na sortowanie dzieki temu mozemy przypisac zwrocony czas do labela
            
         */

        private void btnInsertionSort1(object sender, EventArgs e)
        {
            if (tempArray != null)
                scoreLabel.Text = "insertionSort time "+InsertionSort.insertionSort1(tempArray, tempArray.Length,ref sortedArray);
            
        }

        private void btnInsertionSort2(object sender, EventArgs e)
        {
            if (tempArray != null)
                scoreLabel.Text = "insertionSort time "+InsertionSort.insertionSort2(tempArray, tempArray.Length, ref sortedArray);
        }

        private void btnInsertionSort3(object sender, EventArgs e)
        {
            if (tempArray != null)
                scoreLabel.Text = "insertionSort time "+InsertionSort.insertionSort3(tempArray, tempArray.Length, ref sortedArray);
        }

        //==============================
        void heapify3(int[] arr, int n, int i)
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
                (arr[i], arr[largest])=(arr[largest],arr[i]);
                heapify3(arr, n, largest);
            }
        }
        void heapSort3(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                (arr[0], arr[i])=(arr[i],arr[0]);
                heapify3(arr, i, 0);
            }
        }
        ///==============================
        void heapify2(int[] tab, int heap_size, int i)
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
        void budKopiec(int[] tab, int rozmiar)
        {
            for (int i = rozmiar / 2; i > 0; i--)
                heapify2(tab, rozmiar, i);
        }

        void sort(int[] tab, int rozmiar)
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
        ///==========================
        void heapify(int[] arr, int n, int i)
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
        void heapSort(int[] arr, int n)
        {
            // Build max heap
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // Heap sort
            for (int i = n - 1; i >= 0; i--)
            {
                (arr[0], arr[i])=(arr[i],arr[0]);

                // Heapify root element to get highest element at root again
                heapify(arr, i, 0);
            }
        }
        //Pozostale przyciski
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            loading();
        }

        private void btnSeeSortedData_Click(object sender, EventArgs e)
        {
            var dataString = "Sorted data ";
            if (sortedArray != null)
            {
                for(int i=0;i<sortedArray.Length;i++)
                {
                    dataString += "\n " + sortedArray[i].ToString();
                }
                MessageBox.Show(dataString, "Sorted data", MessageBoxButtons.OK);
            }
        }

        private void rndNum1_Click(object sender, EventArgs e)
        {
            if (tempArray != null)
                scoreLabel.Text = "insertionSort time "+rndNumFuncs.bubbleSort(tempArray, tempArray.Length, ref sortedArray);
        }
      
        
        private void rndNum2_Click(object sender, EventArgs e)
        {
            if (tempArray != null)
                scoreLabel.Text = rndNumFuncs.bubbleSort2(tempArray, tempArray.Length, ref sortedArray);
        }
       

        private void rndNum3_Click(object sender, EventArgs e)
        {
            if (tempArray != null)
                scoreLabel.Text = rndNumFuncs.bubbleSort3(tempArray, tempArray.Length, ref sortedArray);
        }

        private void quickSort1_Click(object sender, EventArgs e)
        {
           
            if (tempArray != null)
            {
                var arrayCopy = tempArray;
                long start = Stopwatch.GetTimestamp();

                QuickSortFuncs.quickSort1(ref tempArray, 0, (-1 + tempArray.Length));

                long end = Stopwatch.GetTimestamp();

                scoreLabel.Text = (end - start).ToString();
                sortedArray = tempArray;
                tempArray = arrayCopy;
            }
        }

        private void quickSort2_Click(object sender, EventArgs e)
        {
            var arrayCopy = tempArray;
            long start = Stopwatch.GetTimestamp();

            QuickSortFuncs.quickSort3(0, (-1+tempArray.Length),ref tempArray);

            long end = Stopwatch.GetTimestamp();

            scoreLabel.Text = (end - start).ToString();
            sortedArray = tempArray;
            tempArray = arrayCopy;
        }

        private void quickSort3_Click(object sender, EventArgs e)
        {
            var arrayCopy = tempArray;
            long start = Stopwatch.GetTimestamp();

            QuickSortFuncs.quickSort2(ref tempArray,0,(-1+tempArray.Length));

            long end = Stopwatch.GetTimestamp();

            scoreLabel.Text = (end - start).ToString();
            sortedArray = tempArray;
            tempArray = arrayCopy;
        }

        private void generateFileBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string text ="";
            var amountOfNumbers = Int64.Parse(textboxAmountOfNumbers.Text);
            var minimalna = Int64.Parse(min.Text);
            var maksymalna = Int64.Parse(max.Text);
            //j = numericUpDown1.Value;
            for (int j = 0; j <=  amountOfNumbers; j++)
            {
                
                text += rnd.Next()+"\n";
               // Console.WriteLine(rnd.Next());
            }
            Stream rndNumStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((rndNumStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter rndNumWriter = new StreamWriter(rndNumStream))
                    {
                        rndNumWriter.WriteLine(text);
                        rndNumWriter.Flush();
                        rndNumWriter.Close();
                    }
                    rndNumStream.Close();
                }
            }
        }

        private void mergesort1_Click(object sender, EventArgs e)
        {
            long start = Stopwatch.GetTimestamp();
            mergeSort(tempArray, 0, tempArray.Length - 1);
            long end = Stopwatch.GetTimestamp();
            scoreLabel.Text = (end - start).ToString();
        }

        private void mergesort2_Click(object sender, EventArgs e)
        {
            long start = Stopwatch.GetTimestamp();
            mergeSort2(tempArray, 0, tempArray.Length - 1);
            long end = Stopwatch.GetTimestamp();
            scoreLabel.Text = (end - start).ToString();
        }

        private void mergesort3_Click(object sender, EventArgs e)
        {
            long start = Stopwatch.GetTimestamp();
            merge_sort3(tempArray, 0, tempArray.Length - 1);
            long end = Stopwatch.GetTimestamp();
            scoreLabel.Text = (end - start).ToString();
        }

        private void heapsort1_Click(object sender, EventArgs e)
        {
            long start = Stopwatch.GetTimestamp();
            heapSort(tempArray,tempArray.Length);
            long end = Stopwatch.GetTimestamp();
            scoreLabel.Text = (end - start).ToString();
        }

        private void heapsort2_Click(object sender, EventArgs e)
        {
            long start = Stopwatch.GetTimestamp();
            sort(tempArray, tempArray.Length-1);
            long end = Stopwatch.GetTimestamp();
            scoreLabel.Text = (end - start).ToString();
        }

        private void heapsort3_Click(object sender, EventArgs e)
        {
            long start = Stopwatch.GetTimestamp();
            heapSort3(tempArray, tempArray.Length - 1);
            long end = Stopwatch.GetTimestamp();
            scoreLabel.Text = (end - start).ToString();
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
