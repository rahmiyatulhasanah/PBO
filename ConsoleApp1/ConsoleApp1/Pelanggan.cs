using System;

namespace PesanMakanan
{
    public class Pelanggan
    {
        private string namaPengirim;
        private string namaPenerima;
        private string alamatP;
        private string noHP;

        public void inputdata()
        {
            Pelanggan dataPelanggan = new Pelanggan();
            Console.Write("Nama Pengirim   : ");
            namaPengirim = Console.ReadLine();
            Console.Write("Nama Penerima   : ");
            namaPenerima = Console.ReadLine();
            Console.Write("Alamat Penerima : ");
            alamatP = Console.ReadLine();
            Console.Write("No. HP          : ");
            noHP = Console.ReadLine();
        }

        public void tampilkan()
        { 
            Console.WriteLine("Nama Pengirim    : " + namaPengirim);
            Console.WriteLine("Nama Penerima    : " + namaPenerima);
            Console.WriteLine("Alamat Penerima  : " + alamatP);
            Console.WriteLine("No.HP            : " + noHP);
        }

        public void reinputdata(string option)
        {
            while (option == "T")
            {
                Console.WriteLine("\nSilahkan masukkan kembali datamu:");
                inputdata();
                //Console.WriteLine("\nBerikut data kamu yang telah diperbaharui:");
                //tampilkan();
                Console.WriteLine("Apakah data baru tersebut sudah benar? (Y/T)");
                option = Console.ReadLine();
            }
        }
    }
}
