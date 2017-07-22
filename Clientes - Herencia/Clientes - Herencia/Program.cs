using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes___Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteVentas cliente = new ClienteVentas();

            cliente.IdCliente = 39210915;
            cliente.Nombre = "Fabián Norberto";
            cliente.Apellido = "Escobar";

            cliente.RFC = "HEHM";
            cliente.Direccion = "Riglos 6542";
            cliente.Colonia = "Gregorio de Laferrere";
            cliente.Municipio = "La Matanza";
            cliente.EsCredito = true;

            Console.WriteLine("Nuevo Cliente:");
            Console.WriteLine(cliente.Apellido + ", " + cliente.Nombre);
            Console.WriteLine(cliente.Direccion + ", " + cliente.Colonia + ", " + cliente.Municipio);
            
            Console.WriteLine(cliente.RFC);

            if (cliente.EsCredito)
                Console.WriteLine("El cliente tiene crédito");
            else
                Console.WriteLine("El cliente no tiene crédito");

            Console.ReadKey();
        }
    }
}
