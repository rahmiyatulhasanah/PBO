using System;

namespace PesanMakanan
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Welcome
            Console.WriteLine("===========================\nSelamat Datang! :)");
            Console.WriteLine("Pengen pesan apa hari ini?");
            Console.WriteLine("===========================\n\n");
            #endregion

            #region Pelanggan Menginput Data
            Console.WriteLine("Sebelumnya, silahkan masukkan datamu terlebih dahulu! \n(Nama Pengirim, Nama Penerima, No.Telp., dan Alamat Penerima)");
            Pelanggan dataPelanggan = new Pelanggan();
            dataPelanggan.inputdata();

            Console.WriteLine("Apakah data tersebut sudah benar? (Y/T)");
            string option = Console.ReadLine();
            dataPelanggan.reinputdata(option);
            #endregion

            Console.WriteLine("===========================\n\n");

            #region Pelanggan Memilih Restoran
            //UNDER CONSTRUCTION
            #endregion

            Console.WriteLine("===========================\n\n");

            #region Pelanggan Memilih Pesanan
            Makanan makanan = new Makanan();
            makanan.Search();
            Minuman minuman = new Minuman();
            minuman.Search();
            #endregion

            Console.WriteLine("===========================\n\n");

            #region Proses Pembayaran
            Console.WriteLine("Lakukan pembayaran");
            #endregion

            Console.WriteLine("===========================\n\n");
        }
    }
}
