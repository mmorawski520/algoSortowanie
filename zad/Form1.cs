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

    //*******************
    // commity na gh są trochę nieczytlene więc powstał plik txt z dziennikiem zdarzen
    //*******************
    public partial class Form1 : Form
    {
        //Ta zmienna przechowuje wczytana tablice przekazuje ja do funkcji/metod i nie zmieniam jej wartosci
        int[] tempArray;
        //Ta zmienna przechowuje posortowana tablice przekazuje ja do funkcji/metod aby zmienic jej wartosc
        int[] sortedArray;

        //string currentSort;
        string fastestSort;
        long fastestSortTime = 10000;
        public Form1()
        {
            InitializeComponent();
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
                            if (!string.IsNullOrEmpty(line))
                            {
                                tempArray[counter] = Int32.Parse(line);
                            }
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

            {

                var licznik = 0;

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {

                    InsertionSort.insertionSort1(tempArray, tempArray.Length, ref sortedArray);
                    licznik++;
                }
                stopwatch.Stop();
                scoreLabel.Text = "Insertion sort 1 time" + stopwatch.ElapsedMilliseconds;
                if (Int64.Parse(stopwatch.ElapsedMilliseconds.ToString()) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest sort  insertion sort 1 : " + stopwatch.ElapsedMilliseconds.ToString();
                }
            }

        }

        private void btnInsertionSort2(object sender, EventArgs e)
        {
            if (tempArray != null)

            {

                var licznik = 0;
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {

                    InsertionSort.insertionSort2(tempArray, tempArray.Length, ref sortedArray);
                    licznik++;
                }
                stopwatch.Stop();
                scoreLabel.Text = "Insertion sort 1 time" + stopwatch.ElapsedMilliseconds;
                if (Int64.Parse(stopwatch.ElapsedMilliseconds.ToString()) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest sort insertion sort 2 : " + stopwatch.ElapsedMilliseconds.ToString();
                }
            }

        }

        private void btnInsertionSort3(object sender, EventArgs e)
        {
            if (tempArray != null)

            {
                var sortScore = " ";
                var licznik = 0;
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {

                    InsertionSort.insertionSort3(tempArray, tempArray.Length, ref sortedArray);
                    licznik++;
                }
                stopwatch.Stop();
                scoreLabel.Text = "Insertion sort 1 time" + stopwatch.ElapsedMilliseconds;
                if (Int64.Parse(stopwatch.ElapsedMilliseconds.ToString()) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest sort insertion sort 3 : " + stopwatch.ElapsedMilliseconds.ToString();
                }

            }

        }

        private void quickSort1_Click(object sender, EventArgs e)
        {

            if (tempArray != null)

            {
                var sortScore = " ";
                var licznik = 0;
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var arrayCopy = tempArray;
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {

                    QuickSortFuncs.quickSort1(ref tempArray, 0, (-1 + tempArray.Length));

                    licznik++;
                }

                stopwatch.Stop();
                sortScore = stopwatch.ElapsedMilliseconds.ToString();
                sortedArray = tempArray;
                tempArray = arrayCopy;
                scoreLabel.Text = "quick sort time " + sortScore.ToString();
                if (Int64.Parse(sortScore) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest sort quick sort 1 : " + sortScore.ToString();
                }
            }
        }

        private void quickSort2_Click(object sender, EventArgs e)
        {

            if (tempArray != null)

            {
                var sortScore = " ";
                var licznik = 0;
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    var arrayCopy = tempArray;

                    var stopwatch = new Stopwatch();
                    stopwatch.Start();

                    QuickSortFuncs.quickSort2(ref tempArray, 0, (-1 + tempArray.Length));

                    stopwatch.Stop();
                    sortScore = stopwatch.ElapsedMilliseconds.ToString();
                    sortedArray = tempArray;
                    tempArray = arrayCopy;

                    licznik++;
                }
                scoreLabel.Text = sortScore.ToString();
                if (Int64.Parse(sortScore) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest sort quick sort 2 : " + sortScore.ToString();
                }
            }
        }

        private void quickSort3_Click(object sender, EventArgs e)
        {

            if (tempArray != null)

            {
                var sortScore = " ";
                var licznik = 0;
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    var arrayCopy = tempArray;

                    var stopwatch = new Stopwatch();
                    stopwatch.Start();

                    QuickSortFuncs.quickSort3(0, (-1 + tempArray.Length), ref tempArray);

                    stopwatch.Stop();
                    sortScore = stopwatch.ElapsedMilliseconds.ToString();
                    sortedArray = tempArray;
                    tempArray = arrayCopy;

                    licznik++;
                }
                scoreLabel.Text = sortScore.ToString();
                if (Int64.Parse(sortScore) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest sort quick sort 3 : " + sortScore.ToString();
                }
            }

        }
        private void mergesort1_Click(object sender, EventArgs e)
        {
            if (tempArray != null)

            {
                var sortScore = " ";
                var licznik = 0;
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    MergeSortFuncs.mergeSort1(tempArray, 0, tempArray.Length - 1, ref sortedArray);
                    licznik++;
                }
                stopwatch.Stop();
                sortScore = stopwatch.ElapsedMilliseconds.ToString();
                scoreLabel.Text = "merge sort time " + sortScore.ToString();
                if (Int64.Parse(sortScore) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest merge quick sort 1 : " + sortScore.ToString();
                }
            }

        }

        private void mergesort2_Click(object sender, EventArgs e)
        {
            if (tempArray != null)

            {
                var sortScore = " ";
                var licznik = 0;
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    MergeSortFuncs.mergeSort2(tempArray, 0, tempArray.Length - 1, ref sortedArray);
                    licznik++;
                }
                stopwatch.Stop();
                sortScore = stopwatch.ElapsedMilliseconds.ToString();
                scoreLabel.Text = "merge sort 2 time " + sortScore.ToString();
                if (Int64.Parse(sortScore) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest sort merge sort 2 : " + sortScore.ToString();
                }

            }
        }

        private void mergesort3_Click(object sender, EventArgs e)
        {
            if (tempArray != null)

            {
                var sortScore = " ";
                var licznik = 0;
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    MergeSortFuncs.mergeSort3(tempArray, 0, tempArray.Length - 1, ref sortedArray);
                    licznik++;
                }
                stopwatch.Stop();
                sortScore = stopwatch.ElapsedMilliseconds.ToString();
                scoreLabel.Text = "merge sort 3 time " + sortScore.ToString();
                if (Int64.Parse(sortScore) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest sort merge sort 3 : " + sortScore.ToString();
                }
            }
        }

        private void heapsort1_Click(object sender, EventArgs e)
        {
            var sortScore = " ";
            if (tempArray != null)

            {

                var licznik = 0;
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    sortScore = HeapSortFuncs.heapSort2(tempArray, tempArray.Length, ref sortedArray);
                    licznik++;
                }
            }
            scoreLabel.Text = "heap sort time " + sortScore.ToString();
            if (Int64.Parse(sortScore) < fastestSortTime)
            {
                fastestSortLabel.Text = "the fastest sort heap sort 1 : " + sortScore.ToString();
            }
        }

        private void heapsort2_Click(object sender, EventArgs e)
        {
            var sortScore = " ";
            if (tempArray != null)

            {

                var licznik = 0;
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    sortScore = HeapSortFuncs.heapSort3(tempArray, tempArray.Length, ref sortedArray);
                    licznik++;
                }
            }
            scoreLabel.Text = "heap sort time " + sortScore.ToString();
            if (Int64.Parse(sortScore) < fastestSortTime)
            {
                fastestSortLabel.Text = "the fastest sort heap sort 2 : " + sortScore.ToString();
            }
        }

        private void heapsort3_Click(object sender, EventArgs e)
        {
            var sortScore = " ";
            if (tempArray != null)

            {

                var licznik = 0;
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    sortScore = HeapSortFuncs.heapSort1(tempArray, tempArray.Length, ref sortedArray);
                    licznik++;
                }
            }
            scoreLabel.Text = "heap sort time " + sortScore.ToString();
            if (Int64.Parse(sortScore) < fastestSortTime)
            {
                fastestSortLabel.Text = "the fastest sort heap sort 3 : " + sortScore.ToString();
            }
        }

        private void bubbleSort1_Click(object sender, EventArgs e)
        {

            if (tempArray != null)

            {

                var licznik = 0;
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    bubbleSortFuncs.bubbleSort(tempArray, tempArray.Length, ref sortedArray);
                    licznik++;
                }
                stopwatch.Stop();
                scoreLabel.Text = "bubble sort 1 time " + stopwatch.ElapsedMilliseconds;

                if (Int64.Parse(stopwatch.ElapsedMilliseconds.ToString()) < fastestSortTime) ;
                {
                    fastestSortLabel.Text = "the fastest sort bubble sort 1 : " + stopwatch.ElapsedMilliseconds.ToString();
                }

            }
        }

        private void bubbleSort2_Click(object sender, EventArgs e)
        {
            if (tempArray != null)

            {

                var licznik = 0;
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    bubbleSortFuncs.bubbleSort2(tempArray, tempArray.Length, ref sortedArray);
                    licznik++;
                }
                stopwatch.Stop();
                scoreLabel.Text = "bubble sort 1 time " + stopwatch.ElapsedMilliseconds;
                if (Int64.Parse(stopwatch.ElapsedMilliseconds.ToString()) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest sort bubble sort 2 : " + stopwatch.ElapsedMilliseconds.ToString();
                }
            }
        }

        private void bubbleSort3_Click(object sender, EventArgs e)
        {
            if (tempArray != null)

            {

                var licznik = 0;
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                while (licznik < Int32.Parse(IleSortowanTextBox.Text))
                {
                    bubbleSortFuncs.bubbleSort3(tempArray, tempArray.Length, ref sortedArray);
                    licznik++;
                }
                stopwatch.Stop();
                scoreLabel.Text = "bubble sort 1 time " + stopwatch.ElapsedMilliseconds;

                if (Int64.Parse(stopwatch.ElapsedMilliseconds.ToString()) < fastestSortTime)
                {
                    fastestSortLabel.Text = "the fastest sort bubble sort 3 : " + stopwatch.ElapsedMilliseconds.ToString();
                }
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
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    dataString += "\n " + sortedArray[i].ToString();
                }
                sortedDataTextBox.Text = dataString;
            }
        }

        private void generateFileBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string text = "";
            var amountOfNumbers = Int64.Parse(textboxAmountOfNumbers.Text);
            int minimalna = Int32.Parse(minTextBox.Text);
            int maksymalna = Int32.Parse(maxTextBox.Text);

            for (int j = 0; j <= amountOfNumbers; j++)
            {

                text += rnd.Next(minimalna, maksymalna) + "\n";

            }
       
            Stream fileStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter fileWriter = new StreamWriter(fileStream))
                    {
                        fileWriter.WriteLine(text);
                        fileWriter.Flush();

                        fileWriter.Close();
                    }
                    fileStream.Close();
                }
            }
        }

        private void buttonUnsortedData_Click(object sender, EventArgs e)
        {
            var dataString = "Unsorted data ";
            if (tempArray != null)
            {
                for (int i = 0; i < tempArray.Length; i++)
                {
                    dataString += "\n " + tempArray[i].ToString();
                }
                sortedDataTextBox.Text = dataString;
            }
        }
    }
}