using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // s = 1 + 2 + 3 + ... + 10 = (1+10)*10/2 = 55
            
            int i = 1;
            int s = 0;

            while (i<=10)
            {
                s = s + i;
                i = i + 1;
                Console.WriteLine("Aktualna wartość s wynosi: {0}", s);
            }

            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
