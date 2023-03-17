using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AplikasiKasir
{
    /// <summary>
    /// main class program aplikasi kasir
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            ///<summary>
            ///membuat list menu beserta harganya
            ///</summary>
            Console.WriteLine("\t\t===========================================================================================\n");
            Console.WriteLine("\t\t                            Program Pembelian Makanan dan Minuman");
            Console.WriteLine("\t\t                                      CAFE Ketje");
            Console.WriteLine("\t\t                           Jalan Syamsudin Uban No.17, kebun handil, Jambi");
            Console.WriteLine("\t\t                                      0877-2472-2347\n");
            Console.WriteLine("\t\t===========================================================================================\n\n");
            Console.WriteLine("Minuman\n");
            Console.WriteLine(" 1. Thai Tea                  : Rp. 7000");
            Console.WriteLine(" 2. Coffe Latte               : Rp. 10.000");
            Console.WriteLine(" 3. Taro Latte                : Rp. 15.000");
            Console.WriteLine(" 4. Matcha Latte              : Rp. 17.000");
            Console.WriteLine(" 5. Ovomaltine                : Rp. 20.000");

            Console.WriteLine("Makanan\n");
            Console.WriteLine(" 1. chicken salted egg         : Rp. 20.000");
            Console.WriteLine(" 2. chicken katsu              : Rp. 18.000");
            Console.WriteLine(" 3. chicken blackpaper         : Rp. 21.000");
            Console.WriteLine(" 4. kwetiaw beef               : Rp. 17.000");
            Console.WriteLine(" 5. Spagetti carbonara         : Rp. 23.000");

            Console.WriteLine("Snack\n");
            Console.WriteLine(" 1. French Fries              : Rp. 10.000");
            Console.WriteLine(" 2. Onion rings               : RP. 13.000");
            Console.WriteLine(" 3. Crispy Nuget              : Rp. 15.000");
            Console.WriteLine(" 4. Risol Crispy              : Rp. 10.000");
            Console.WriteLine(" 5. Jamur Crispy              : Rp. 10.000");

            ///<summary>
            ///Looping input jumlah dengan menggunakan kondisi do while
            ///</summary>
            int jml;
            do
            {
                Console.WriteLine("Masukkan Jumlah Barang");
                jml = int.Parse(Console.ReadLine());
            }
            while (jml <= 0 || jml > 7);

            ///<summary>
            ///Looping dengan menggunakan kombinasi Array. Akan mencetak inputan nama barang dan harga barang
            ///</summary>

            string[] nama = new string[jml];
            int[] harga = new int[jml];
            int total = 0;
            int bayar, kembali;

            for (int i = 0; i < jml; i++)
            {
                do
                {
                    Console.WriteLine("\nMasukkan nama barang Ke-" + (i + 1));
                    nama[i] = Console.ReadLine();
                }
                while (nama[i].Length <= 0 || nama[i].Length >= 20);

                do
                {
                    Console.WriteLine("Masukkan harga barang Ke-" + (i + 1));
                    harga[i] = int.Parse(Console.ReadLine());
                    ///<summary>
                    ///kondisi user harus mengingat harga barang antara 5000-100000
                    ///</summary>
                }
                while (harga[i] <= 5000 || harga[i] >= 100000);
            }

            //deklarasi

            ///<summary>
            ///namak = nama kasir
            ///namap = nama pembeli
            ///</summary>
            string namak;
            string namap;
            string tanggal;
            string jam;

            Console.Write("\n\nNama Kasir : ");
            namak = Console.ReadLine();

            Console.Write("Nama Pembeli : ");
            namap = Console.ReadLine();

            tanggal = DateTime.Now.ToString("dd/MM/yyy");

            jam = DateTime.Now.ToString("hh:mm:ss");

            ///<summary>
            ///Menampilkan nama barang yang dibeli
            ///</summary>
            Console.Write("Tanggal Transaksi : " + tanggal);
            Console.Write("\nJam Transaksi : " + jam);
            Console.WriteLine("\n\nBarang yang dibeli");
            Console.WriteLine("======================================");
            for (int i = 0; i < jml; i++)
            {
                Console.WriteLine((i + 1) + ". " + nama[i] + "   " + harga[i]);
            }

            foreach (int i in harga)
            {
                total += i;
            }
            ///<summary>
            ///Menampilkan total harga
            ///</summary>

            Console.WriteLine("============================");
            Console.WriteLine("Total             " + total);

            do
            {
                Console.Write("\n\n Uang yang dibayar : ");
                bayar = int.Parse(Console.ReadLine());

                //Uang Kembali dari uang bayar yang diinput user
                kembali = bayar - total;

                //jika Uang bayar lebih kecil dari total harga
                if (bayar < total)
                {
                    Console.WriteLine("Maaf, Uang Anda Kurang !!");
                    Console.WriteLine("-------------------------");
                }
                //jika uang bayar lebih dari total harga
                else
                {
                    Console.WriteLine("\n\n Uang Kembalian Anda Rp. " + kembali + ",00");
                }
            }
            while (bayar < total);

            //Ucapan terimakasih kepada pembeli
            Console.WriteLine("\n\n\t\t                 Selamat Menikmati");
            Console.WriteLine("\n\n\t\t       Terima Kasih telah ke CAFE Ketje");
            Console.WriteLine();
        }
    }
}

        