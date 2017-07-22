using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Ingrese nombre: \n");
            String nombre = Console.ReadLine();

            Console.WriteLine("\n Ingrese apellido: \n");
            String apellido = Console.ReadLine();

            Saludar(nombre, apellido);
        }

        static void Saludar(String nombre, String apellido)
        {
            Console.WriteLine("\n Buenas noches, " + nombre + " " + apellido + "\n");
            Console.ReadLine();
        }
    }
}
