using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhLuongNhanSu
{
    class Program
    {
        static void Main(string[] args)

        {


            // CÂU 1 _________________________________________________________________________
            /*
            Console.WriteLine("__________________WELCOME____________________\n");
            Console.Write("Nhap ten :");
            string name = Console.ReadLine();
            Console.Write("nhap he so luong :");
            double hesoluong = double.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban :");
            double luongcoban = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so phu cap :");
            double hesophucap = double.Parse(Console.ReadLine());

            Tinh nv = new Tinh(name, hesoluong, luongcoban, hesophucap);
            double result = nv.tinhLuong();
            Console.WriteLine("______________RESULT_____________ \n \n ");
            Console.WriteLine(nv.Display());

            Console.WriteLine("___Luong__\n");
            Console.WriteLine(result + " VND");
            Console.ReadLine();
            */


            // CAU 2 ____________________________________________________________________________________


            Nhanvien nv = new Nhanvien();
            nv.ChonNV();
            Console.ReadLine();

        }
    }
    abstract public class oper
    {
        abstract public double tinhLuong();
        abstract public string Display();
    }
    class Luong : oper
    {
        private string name;
        private double hesoluong = 2.3;
        private double luongcoban = 450;
        Luong()
        {

        }
        public Luong(string name, double hesoluong, double luongcoban)
        {
            this.name = name;
            this.hesoluong = hesoluong;
            this.luongcoban = luongcoban;
        }
        public override double tinhLuong()
        {
            return this.hesoluong * this.luongcoban;
        }
        public override string Display()
        {
            return "\nHo ten: " + this.name + "\nHe so luong: " + this.hesoluong + "\nLuong co ban: " + this.luongcoban + "\n";
        }
    }

    class Tinh : Luong
    {
        private double hesophucap;
        public Tinh(string name, double hesoluong, double luongcoban, double hesophucap) : base(name, hesoluong, luongcoban)
        {
            this.hesophucap = hesophucap;
        }
        public new string Display()
        {
            return base.Display() + "He so phu cap: " + this.hesophucap;
        }
        public override double tinhLuong()
        {
            return base.tinhLuong() * this.hesophucap;
        }

    }


    // CÂU 2 ____________________________________________________________________________
    abstract public class TinhLuong
    {

        abstract public double NvSanXuat(double a);
        abstract public double NvCongNhat(double a);
        abstract public double NvQL(double a, double b);
    }
    public class menu
    {
        public void Menu()
        {
            Console.WriteLine("________________VUI LONG CHON LOAI NHAN VIEN ______________________");
            Console.WriteLine("_________________________________");
            Console.WriteLine("|__ nhap 1: nhan vien san xuat__|");
            Console.WriteLine("|__ nhap 2: nhan vien cong nhat_|");
            Console.WriteLine("|__ nhap 3: nhan vien quan ly  _|");
            Console.WriteLine("---------------------------------");
        }
    }
    class Nhanvien : TinhLuong
    {
        private string Ten;
        private string ngaysinh;
        private string diachi;
        private double result;

        public Nhanvien() { }
        public Nhanvien(string Ten , string ngaysinh, string diachi)
        {
            this.Ten = Ten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
        }

        public string  display()
        {

            return "\nHo ten: " + this.Ten + "\nNgay sinh:" + this.ngaysinh + " \nDia chi:" + this.diachi + "\n";
        }
        public override double NvSanXuat(double sosanpham)
        {
            return sosanpham * 2000;
        }
        public override double NvCongNhat(double songaycong)
        {
            return songaycong * 50000;
        }
        public override double NvQL(double hesoluong, double luongcoban)
        {
            return hesoluong*luongcoban;
        }


        public void ChonNV()
        {
            menu menu = new menu();
            menu.Menu();
            Console.Write("Chon: ");
            int luachon = int.Parse(Console.ReadLine());
            while (luachon < 1 && luachon > 3)
            {
                Console.WriteLine(" vui long chon so phu hop!!");
                Console.Write("Nhap lai so:");
                luachon = int.Parse(Console.ReadLine());
            }
            if (luachon == 1)
            {
                Console.WriteLine("______| Nhan vien san xuat|______ ");
                Console.Write("\nNhap ten:");
                this.Ten = Console.ReadLine();
                Console.Write("Nhap ngay sinh:");
                this.ngaysinh = Console.ReadLine();
                Console.Write("Nhap dia chi:");
                this.diachi = Console.ReadLine();
                Console.Write("\nNhap so san san pham: ");
                double result = double.Parse(Console.ReadLine());
                this.result = NvSanXuat(result);
                Console.WriteLine("_____result_____");
                Console.WriteLine(display());
                Console.WriteLine("Luong: " + this.result);
            }
            else if (luachon == 2)
            {
                Console.WriteLine("______| Nhan vien cong nhat|______ ");
                Console.Write("\nNhap ten:");
                this.Ten = Console.ReadLine();
                Console.Write("Nhap ngay sinh:");
                this.ngaysinh = Console.ReadLine();
                Console.Write("Nhap dia chi:");
                this.diachi = Console.ReadLine();
                Console.Write("\nNhap so ngay cong: ");
                double result = double.Parse(Console.ReadLine());
                this.result = NvCongNhat(result);
                Console.WriteLine("_____result_____");
                Console.WriteLine(display());
                Console.WriteLine("Luong: " + this.result);
            }
            else if (luachon == 3)
            {
                Console.WriteLine("______| Nhan vien Quan Ly |______ ");
                Console.Write("\nNhap ten:");
                this.Ten = Console.ReadLine();
                Console.Write("Nhap ngay sinh:");
                this.ngaysinh = Console.ReadLine();
                Console.Write("Nhap dia chi:");
                this.diachi = Console.ReadLine();
                Console.Write("\nNhap he so luong: ");
                double hesoluong = double.Parse(Console.ReadLine());
                Console.Write("\nNhap luong co ban: ");
                double luongcoban = double.Parse(Console.ReadLine());
                this.result = NvQL(hesoluong, luongcoban);
                Console.WriteLine("_____result_____");
                Console.WriteLine(display());
                Console.WriteLine("Luong: " + this.result);
            }
            else {
                Console.WriteLine(" Lua chon khong ton tai!!");
            }

        }
    }
}   


