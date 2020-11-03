using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar boku trójkąta prostokątnego liczbowego: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n+1; i++) // i - numer wiersza
            {
                for (int j = 0; j < i; j++) // j - numer gwiazdki w ustalonym wierszu
                {
                    Console.Write("{0,4} ", i*(j+1));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
