using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary_Saludar;

namespace Saludo_en_capas
{
    class CapaPresentacion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Ingrese nombre: \n");
            String nombre = Console.ReadLine();

            Console.WriteLine("\n Ingrese apellido: \n");
            String apellido = Console.ReadLine();

            CapaNegocio.Saludar(nombre, apellido);
        }
    }
}
