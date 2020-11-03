using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i<=10)
            {
                Console.WriteLine("Przebieg pętli nr: {0}", i);
                // i = i + 1;
                // i++;
                i += 1;
            }

            Console.ReadKey();
        }
    }
}
