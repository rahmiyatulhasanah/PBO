using System;
using System.Collections.Generic;
using System.Text;

namespace PesanMakanan
{
    public class Pembayaran
    {
        public int totalpesan;
        public void Sum(int totalMakanan, int totalMinuman)
        {
            totalpesan = totalMakanan + totalMinuman;
        }

        public void showSum(int totalpesan)
        {
            Console.WriteLine("Total Belanja : " + totalpesan);
        }
    }
}
