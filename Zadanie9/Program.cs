using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość zmiennej n: ");
            int n = int.Parse(Console.ReadLine());

            int suma = 0;

            // 1=2*0+1 3=2*1+1 5=2*2+1 7=2*3+1

            for (int i = 0; i < n-1; i++)
            {
                Console.Write("{0} + ", 2*i+1);
                suma = suma + (2 * i + 1);
            }

            Console.Write("{0} ", 2 * (n-1) + 1);
            suma = suma + (2 * (n-1) + 1);

            Console.Write("= {0}", suma);

            Console.ReadKey();
        }
    }
}
