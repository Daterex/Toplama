using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            Console.Write("1. Sayı : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine(sayi1+ " ve " +sayi2 +" Sayısının Toplamı : " +toplam);
            //Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", sayi1, sayi2, toplam);
            Console.ReadKey();  
        }
    }
}