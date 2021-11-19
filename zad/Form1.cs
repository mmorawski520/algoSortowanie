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
        
        /* Przyciski do sortowania przez wsawianie 
         Funkcje do sortowania znajduja sie w odzielnym w pliku i specjalnej klasie
         jako argumenty trzeba podac nieposortowana tablice, dlugosc tej tablicy, oryginalna tablice sorted array
         wartosc sortedArray ulegnie zmianie poprzez referencje
          
        Funkcje do sortowania zwracaja stringa z czasem poswieconym na sortowanie dzieki temu mozemy przypisac zwrocony czas do labela
            
         */
        private void btnInsertionSort1(object sender, EventArgs e)
        {
            if (tempArray != null)
                //tutaj wywolujemy funkcje/metode do sortowania ktora zwraca nam czas
                label1.Text = "sorting time "+InsertionSort.sorting1(tempArray, tempArray.Length,ref sortedArray);
            
        }

        private void btnInsertionSort2(object sender, EventArgs e)
        {
            if (tempArray != null)
                label1.Text = "sorting time "+InsertionSort.sorting2(tempArray, tempArray.Length, ref sortedArray);
        }

        private void btnInsertionSort3(object sender, EventArgs e)
        {
            if (tempArray != null)
                label1.Text = "sorting time "+InsertionSort.sorting3(tempArray, tempArray.Length, ref sortedArray);
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

        private void bubbleSort1_Click(object sender, EventArgs e)
        {
            if (tempArray != null)
                //sortowanie_babelkowe(tempArray, tempArray.Length);
                label1.Text = "sorting time "+BubbleSortFuncs.sortowanie_babelkowe(tempArray, tempArray.Length, ref sortedArray);
        }
      
        
        private void bubbleSort2_Click(object sender, EventArgs e)
        {
            if (tempArray != null)
                label1.Text = BubbleSortFuncs.sortowanie_babelkowe2(tempArray, tempArray.Length, ref sortedArray);
        }
       

        private void bubbleSort3_Click(object sender, EventArgs e)
        {
            if (tempArray != null)
                label1.Text = BubbleSortFuncs.sortowanie_babelkowe3(tempArray, tempArray.Length, ref sortedArray);
        }

        private void quickSort1_Click(object sender, EventArgs e)
        {
           
            if (tempArray != null)
            {

                long start = Stopwatch.GetTimestamp();
                QuickSortFuncs.quickSort1(tempArray, 0, (-1 + tempArray.Length));
                long end = Stopwatch.GetTimestamp();
                label1.Text = (end - start).ToString();
            }
        }

        private void quickSort2_Click(object sender, EventArgs e)
        {
            long start = Stopwatch.GetTimestamp();
            QuickSortFuncs.quickSort3(0, (-1+tempArray.Length), tempArray);
            long end = Stopwatch.GetTimestamp();
            label1.Text = (end - start).ToString();
        }

        private void quickSort3_Click(object sender, EventArgs e)
        {
            long start = Stopwatch.GetTimestamp();
            QuickSortFuncs.quickSort2(tempArray,0,(-1+tempArray.Length));
            long end = Stopwatch.GetTimestamp();
            label1.Text = (end - start).ToString();
        }

        private void generateFileBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string text ="";

             //j = numericUpDown1.Value;
            for (int j = 0; j <= numericUpDown1.Value ; j++)
            {
                text += rnd.Next()+"\n";
               // Console.WriteLine(rnd.Next());
            }
            Stream patientStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((patientStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter patientWriter = new StreamWriter(patientStream))
                    {
                        patientWriter.WriteLine(text);
                        patientWriter.Flush();
                        patientWriter.Close();
                    }
                    patientStream.Close();
                }
            }
        }
    }
}
