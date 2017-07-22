using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    public class MostrarHashTable
    {
        Hashtable Tabla;

        public MostrarHashTable()
        {
            Tabla = new Hashtable();
        }

        public void AgregarDatos()
        {
            Tabla.Add("C001", "Producto 1");
            Tabla.Add("J546", "Producto 2");
            Tabla.Add("L899", "Producto 3");
            Tabla.Add("M524", "Producto 4");
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Existen " + Tabla.Count + " elementos. Dame la descripción del elemento con clave:");
            string cadena = Console.ReadLine();

            if (Tabla[cadena] == null)
                Console.WriteLine("\n El elemento no existe");
            else
            {
                Console.WriteLine("\n El elemento encontrado es:");
                Console.WriteLine(Tabla[cadena]);
            }
        }

        public void Eliminar(string key)
        {
            Tabla.Remove(key);
        }
    }
}
