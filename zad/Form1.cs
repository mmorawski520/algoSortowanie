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


namespace zad
{
    public partial class Form1 : Form
    {
        int[] tablica1 = { 1, 4, 5, 6, 7, 1, 5 };
        DateTime start;
        DateTime koniec;
        public Form1()
        {
            InitializeComponent();
        }

        void Sortowanie(int []tab, int size)
        {
            int temp, j;
            start = DateTime.Now;
            for (int i = 1; i < size; i++)
            {
                temp = tab[i];

                for (j = i - 1; j >= 0 && tab[j] > temp; j--)
                    tab[j + 1] = tab[j];

                tab[j + 1] = temp;
            }
            koniec = DateTime.Now;
            label2.Text = (koniec-start).TotalMilliseconds.ToString();
            Wypisywanie(tab,size);
        }

        void sortowanie_przez_wstawianie(int []tab, int n)
        {
            int pom, j;
            start = DateTime.Now;
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
            koniec = DateTime.Now;
            label2.Text = (koniec - start).TotalMilliseconds.ToString();
        }



        void Wypisywanie(int[] tab, int size)
        {
            label1.Text = "";
            for (int i = 1; i < size; i++)
            {
                label1.Text += "\n " + tab[i];
            }
        }

        void Ladowanie() {
            
            using (StreamReader file = new StreamReader("C:/Users/student/Desktop/dane.txt"))
            {
                /*
                int counter = 0;
                //string ln;

                string[] lines = File.ReadAllLines("C:/Users/student/Desktop/dane.txt");
                foreach (string line in lines)
                {
                    
                   
                    if (line != null && line != "")
                    {
                        tablica1[counter] = int.Parse(line);
                    }
               
                }*/
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ladowanie();

            sortowanie_przez_wstawianie(tablica1, tablica1.Length);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sortowanie(tablica1, tablica1.Length);
        }
    }
}
