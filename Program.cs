using System;

namespace exec1
{
    class program
    {
        //Deklarasi Array dengan NIM yang sudah dijumlahkan
        private int[] ghani = new int[2160];
        //Deklarasi Variabel int untuk menyiapkan banyaknya data di array
        private int n;
        
        public void read()
        {
            while(true)
            {
                Console.WriteLine("Masukan banyaknya elemen pada Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 2160)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 2160 Elemen. \n");

            }
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Masukan Elemen Array");
            Console.WriteLine(" ---------------------");

            //Pengguna Memasukan elemen di array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                ghani[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Element array yang telah tersusun");
            Console.WriteLine("------------------------------------");
            for (int mg = 0; mg < n; mg++)
            {
                Console.WriteLine(ghani[mg]);
            }
            Console.WriteLine("");
        }
        public void bubblSortArray()
        {
            for (int i = 1; i < n; i++) //For n-1 passes
            {
                //Pada Pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int mg = 0; mg < n - i; mg++)
                {
                    if (ghani[mg] > ghani [mg + 1]) // Jika elemen tidak dalam urutan yang benar
                    {
                        //Tukar Elemen
                        int temp;
                        temp = ghani[mg];
                        ghani[mg] = ghani[mg + 1];
                        ghani[mg + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Membuat object Bubblesort Vlass
            program myList = new program();
            //Pemanggilan fungsi untuk menerima elemn array
            myList.read();
            //Pemanggilan fungsi untuk mengurutkan array
            myList.bubblSortArray();
            //Pemanggilan fungsi untuk array yang tersusun
            myList.display();
            //Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar. ");
        }
    }   
}