using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesanMakanan
{
    public class Makanan : CariMenu
    {
        public override void Search()
        {
            Console.WriteLine("Pilihan makanan:");
            int pilih = 0;

            Console.WriteLine("(1) Martabak");
            Console.WriteLine("(2) Nasi Goreng");
            pilih = Convert.ToInt32(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Martabak");
                    MartabakPilihan martabak = new MartabakPilihan();
                    martabak.Custom();
                    break;
                case 2:
                    Console.WriteLine("Nasi Goreng");
                    Nasigoreng nasigoreng = new Nasigoreng();
                    nasigoreng.Custom();
                    break;
            }

        }
    }
}
