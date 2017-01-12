using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace amazingprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Wprowadz pierwsza liczbe");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadz druga liczbe");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Wynik = " + (a+b));
            Console.ReadKey();
        }
    }
}
