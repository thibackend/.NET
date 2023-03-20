using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THI HANDSOME!");
            Console.ReadLine();
}
    }



    class NhanVien
    {
        private string Hoten;
        private int tuoi;
        private float hesoluong;
        private float luongcoban;


        public NhanVien(string hoten, int tuoi, float hsl, float lcb)
        {
            this.Hoten = hoten;
            this.tuoi = tuoi;
            this.hesoluong = hsl;
            this.luongcoban = lcb;
        }
    }

}