using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesanMakanan
{

    public class MartabakPilihan : PilihanMakanan
    {
        public int hargaMakanan = 0; 

        public override void Custom()
        {
            int pilih = 0;
            Console.WriteLine("Pilihan Martabak");
            Console.WriteLine("(1) Martabak Manis = 20.000");
            Console.WriteLine("(2) Martabak Black = 30.000");
            pilih = Convert.ToInt32(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Pengen pesan berapa porsi?");
                    int pcs = Convert.ToInt32(Console.ReadLine());
                    hargaMakanan += pcs * 20000;
                    break;
                case 2:
                    Console.WriteLine("Pengen pesan berapa porsi?");
                    pcs = Convert.ToInt32(Console.ReadLine());
                    hargaMakanan += pcs * 30000;
                    break;
            }
            int totalMakanan = hargaMakanan;
            int totalMinuman = 0;
            Console.WriteLine("\nTotal makananmu : " + totalMakanan);
            Pembayaran pembayaran = new Pembayaran();
            pembayaran.Sum(totalMakanan, totalMinuman);

        }
    }
    
    public class Nasigoreng : PilihanMakanan
    {
        public int hargaMakanan = 0;

        public override void Custom()
        {
            Console.WriteLine("Pilihan Nasi Goreng");
            Console.WriteLine("(1) Nasi Goreng Pedas = 16000");
            Console.WriteLine("(2) Nasi Goreng Manis = 15000");
            int pilih = Convert.ToInt32(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Pengen pesan berapa porsi?");
                    int pcs = Convert.ToInt32(Console.ReadLine());
                    hargaMakanan += (pcs * 16000);
                    break;
                case 2:
                    Console.WriteLine("Pengen pesan berapa porsi?");
                    pcs = Convert.ToInt32(Console.ReadLine());
                    hargaMakanan += (pcs * 15000);
                    break;
            }
            int totalMakanan = hargaMakanan;
            int totalMinuman = 0;
            Console.WriteLine("\nTotal makananmu : " + totalMakanan);
            Pembayaran pembayaran = new Pembayaran();
            pembayaran.Sum(totalMakanan, totalMinuman);
        }
    }
}
