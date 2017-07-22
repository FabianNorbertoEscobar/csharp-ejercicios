using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarArrayList Muestra = new MostrarArrayList();

            Console.WriteLine("ARRAYLIST \n");

            Console.WriteLine("Ingrese datos del ArrayList: \n");
            Muestra.CapturaDatos();

            Console.WriteLine("\n ArrayList: \n");
            Muestra.ImprimeDatos();

            MostrarHashTable Tabla = new MostrarHashTable();
            
            Console.WriteLine("\n HASHTABLE \n");

            Tabla.AgregarDatos();
            Tabla.MostrarDatos();

            Console.ReadKey();

            Tabla.Eliminar("C001");

            Console.WriteLine();
            Tabla.MostrarDatos();

            Console.ReadKey();
        }
    }
}
