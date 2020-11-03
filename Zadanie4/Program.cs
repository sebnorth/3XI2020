using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę b: ");
            int b = int.Parse(Console.ReadLine());

            int i, n;

            if (a > b)
            {
                n = a;
                i = b;
               
            }
            else
            {
                n = b;
                i = a;
            }

            if (i % 2 == 1) i += 1;


            do
            {

                if (i % 2 == 0) Console.Write("{0} ", i);

                i=i+2;

            } while (i<=n);

            Console.ReadKey();
        }
    }
}
