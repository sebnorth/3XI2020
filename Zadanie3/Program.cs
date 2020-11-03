using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;

            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                s = s + i;
                // Console.WriteLine("Wartość zmiennej s po {0}-tym przebiegu pętli wynosi: {1}", i, s);
            }

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
