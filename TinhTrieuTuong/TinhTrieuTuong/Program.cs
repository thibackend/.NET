using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTrieuTuong
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class Hinh {

        protected double PI = 3.14159;
        abstract public double TinhDienTich();

        abstract public double TinhChuVi();

    }


    public class HinhTron:Hinh {
        private double bankinh;
        public HinhTron(double r)
        {
            this.bankinh = r;
        }
        public override double TinhDienTich(){
            return PI * bankinh * bankinh;
        }
        public override double TinhChuVi()
         {
        return 2*PI* bankinh;
        }




}


}
