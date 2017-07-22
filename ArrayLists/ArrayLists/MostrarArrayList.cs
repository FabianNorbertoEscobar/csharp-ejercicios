using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    public class MostrarArrayList
    {
        ArrayList Lista;

        public MostrarArrayList()
        {
            Lista = new ArrayList();
        }

        public void CapturaDatos()
        {
            string cadena;

            for (int i = 0; i < 3; i++)
            {
                cadena = Console.ReadLine();
                Lista.Add(cadena);
            }
        }

        public void ImprimeDatos()
        {
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
