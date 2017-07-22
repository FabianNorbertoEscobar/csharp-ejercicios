using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Saludar
{
    public class CapaNegocio
    {
        public static void Saludar(String nombre, String apellido)
        {
            Console.WriteLine("\n Buenas noches, " + nombre + " " + apellido + "\n");
            Console.ReadLine();
        }
    }
}
