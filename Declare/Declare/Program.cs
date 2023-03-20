using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap mot so: ");
            n = int.Parse(Console.ReadLine()); 
            if(n%2 ==0)
            {
                Console.WriteLine(n + " la so chan");

            }
            else
            {
                Console.WriteLine(n + " la so le");

            }
            Console.ReadLine(); 
        }
    }
}
