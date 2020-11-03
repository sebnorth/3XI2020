using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę b: ");
            int b = int.Parse(Console.ReadLine());

            // Liczba 2 jest dzielnikiem liczby 12.

            if (a % b == 0) Console.WriteLine("Liczba {0} jest dzielnikiem liczby {1}",b,a);
            else Console.WriteLine("Liczba {0} NIE jest dzielnikiem liczby {1}", b, a);

            //Dzielniki liczby 12: 1,2,3,4,6,12.

            int i = 1;

            Console.Write("Dzielniki liczby {0}: ", a);
            
            while (i <= a)
            {
                if (a % i == 0) Console.Write("{0} ", i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
