// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Nhanvien{
    public int age;
    public Nhanvien(int a){
        this.age=a;
    }
    public int get(){
        return this.age;
    }
     
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Nhanvien n1 = new Nhanvien(2);
            Console.WriteLine("hello thi you are: "+n1.get() +" year old");
        }
    }
}