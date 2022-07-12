using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<string> daftarPenjualan = new List<string>();

        daftarPenjualan.Nota(001);

        int 

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("");

            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
            Console.WriteLine("");

            Console.WriteLine("Nomor Menu [1..3] : ");
            Console.Readline();

        }

        public void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();
            penjualan.Tanggal = 07-07-2020;
            penjualan.Customer = Anis;
            penjualan.Jenis = 'T';
            penjualan.Nota = 5000000;

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("Nota : {0}", Nota);
            Console.WriteLine("Tanggal : {0}", penjualan.Tanggal);
            Console.WriteLine("Customer : {0}", penjualan.Customer);
            Console.WriteLine("Jenis [T/K] : {0}", penjualan.Jenis);
            Console.WriteLine("Total Nota : {0}", penjualan.Nota);

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
