using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones_de_tipo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 2.2m;
            bool bandera = false;
            string cadena = string.Empty;
            DateTime fecha = DateTime.MinValue;

            x = i; // conversión permitida

            i = (int)x; // conversión permitida
            // i = x;  no compila

            i = Convert.ToInt32(bandera); // falso será convertidov a 0; verdadero a 1

            Console.WriteLine("i = " + i);
            Console.WriteLine("x = " + x);
            Console.WriteLine("bandera = " + bandera.ToString());
            Console.WriteLine("cadena = " + cadena);
            Console.WriteLine("fecha = " + fecha.ToShortDateString());


            Console.ReadKey();
        }
    }
}
