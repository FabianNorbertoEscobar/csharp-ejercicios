using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[12];

            for (int i = 0; i < 12; i++)
            {
                arreglo[i] = i;
            }

            Console.WriteLine("ARREGLO");

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

            Console.ReadKey();
        }
    }
}
