using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            List<ClienteBase> clientes;
            clientes = new List<ClienteBase>();

            do
            {
                Console.WriteLine("\n Opciones:");
                Console.WriteLine();

                Console.WriteLine("a - Agregar a la lista");
                Console.WriteLine("b - Quitar de la lista");
                Console.WriteLine("c - Mostrar la lista");

                Console.WriteLine();
                Console.WriteLine("s - Salir");

                Console.Write("\n\n Opción: ");
                opcion = Console.ReadLine();

                Console.WriteLine();

                if(opcion.Equals("a"))
                {
                    Console.WriteLine("Ingrese nombre de cliente a agregar:");
                    string cadena = Console.ReadLine();

                    ClienteBase cliente = new ClienteBase();

                    if (!clientes.Exists(c => c.Nombre.Equals(cadena)))
                    {                    
                        cliente.Nombre = cadena;

                        Random rand = new Random();
                        cliente.IdCliente = rand.Next(100000000);
                        
                        clientes.Add(cliente);                    

                        Console.WriteLine("El cliente ha sido agregado exitosamente");
                    }
                    else
                        Console.WriteLine("El cliente ya se encontraba en la lista");
                }
                else if(opcion.Equals("b"))
                {
                    if (!clientes.Count.Equals(0))
                    {
                        Console.WriteLine("Ingrese nombre de cliente a quitar:");

                        string cadena = Console.ReadLine();

                        if (clientes.Exists(cliente => cliente.Nombre.Equals(cadena)))
                        {
                            clientes.RemoveAll(cliente => cliente.Nombre.Equals(cadena));
                            Console.WriteLine("El cliente fue quitado exitosamente");
                        }
                        else
                            Console.WriteLine("El cliente no fue encontrado en la lista");
                        
                    }
                    else
                        Console.WriteLine("No puede quitar clientes de la lista porque la lista está vacía");
                     
                }
                else if(opcion.Equals("c"))
                {
                    if (!clientes.Count.Equals(0))
                    {
                        Console.WriteLine("Lista de Clientes");

                        foreach (ClienteBase cliente in clientes)
                        {
                            Console.WriteLine("\n Cliente:");
                            Console.WriteLine("Id: " + cliente.IdCliente.ToString() + " Nombre: " + cliente.Nombre);
                        }
                    }
                    else
                        Console.WriteLine("La lista de clientes se encuentra VACÍA");
                }

                Console.ReadKey();
                Console.Clear();

            } while (!opcion.Equals("s"));

            Console.WriteLine("Programa terminado");
            Console.ReadKey();
        }
    }
}
