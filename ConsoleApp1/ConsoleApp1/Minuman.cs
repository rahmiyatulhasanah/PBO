using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesanMakanan
{
    public class Minuman : CariMenu
    {
        public int hargaMinuman = 0;
        public override void Search()
        {
            Console.WriteLine("Pengen minum apa nih?");
            int pilih = 0;

            Console.WriteLine("(1) Es Teh");
            Console.WriteLine("(2) Jus Apel");
            Console.WriteLine("(3) Ngga dulu deh");
            pilih = Convert.ToInt32(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Es Teh = 5000");
                    Console.WriteLine("Pengen pesan berapa porsi?");
                    int pcs = Convert.ToInt32(Console.ReadLine());
                    hargaMinuman += (pcs * 5000);
                    break;
                case 2:
                    Console.WriteLine("Jus Apel = 8000");
                    Console.WriteLine("Pengen pesan berapa porsi?");
                    pcs = Convert.ToInt32(Console.ReadLine());
                    hargaMinuman += (pcs * 8000);
                    break;
                case 3:
                    break;
            }
            int totalMinuman = hargaMinuman;
            Console.WriteLine("\nTotal minumanmu : " + totalMinuman);
        }
    }
}
