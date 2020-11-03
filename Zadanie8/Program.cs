using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj wartość zmiennej ile: ");
            int ile = int.Parse(Console.ReadLine());

            for (int i = 0; i < ile; i++)
            {
                Console.Write("{0} ", 7 * i);
            }

            //int licznik = 0;
            //int aktualnaWielokrotnoscSiodemki = 0;

            //while (licznik < ile)
            //{
            //    licznik++;
            //    Console.Write("{0} ", aktualnaWielokrotnoscSiodemki);
            //    aktualnaWielokrotnoscSiodemki += 7;
            //}

            //Console.ReadKey();
        }
    }
}
