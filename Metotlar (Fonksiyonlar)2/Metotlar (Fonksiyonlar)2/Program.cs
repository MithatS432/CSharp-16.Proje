using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar__Fonksiyonlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            // Recursive metot ile faktöriyel
            long sonuc = Faktoriyel(sayi);
            Console.WriteLine($"{sayi}! = {sonuc}");

            // Recursive ile Fibonacci örneği
            Console.WriteLine("Fibonacci Dizisi (ilk 10 terim):");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        static long Faktoriyel(int n)
        {
            if (n <= 1)
                return 1;
            return n * Faktoriyel(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
