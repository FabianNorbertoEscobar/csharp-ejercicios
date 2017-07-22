using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // para trabajar con archivos

namespace Cliente___Clase_Abstracta
{
    public class Archivo : SalidasInterface
    {
        public void ImprimeCliente(ClienteAbstracta cliente)
        {
            try
            {
                StreamWriter archivo = new StreamWriter("ArchivoBitacora.log", true);

                archivo.WriteLine(cliente.IdCliente);
                archivo.WriteLine(cliente.Nombre);
                archivo.WriteLine(cliente.Clave);
                archivo.WriteLine(cliente.RFC);
                archivo.WriteLine(cliente.TipoRegimen);
                archivo.WriteLine(cliente.NombreContacto);

                archivo.Close();
            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("\n -->> No se ha encontrado el directorio para almacenar el archivo");
                Console.WriteLine(e.Message);

                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }

        public void ImprimeDireccion(Direcciones direccion)
        {
            try
            {
                StreamWriter archivo = new StreamWriter("ArchivoBitacora.log", true);

                archivo.WriteLine(direccion.Calle);
                archivo.WriteLine(direccion.NumeroExterior);
                archivo.WriteLine(direccion.NumeroInterior);
                archivo.WriteLine(direccion.Colonia);
                archivo.WriteLine(direccion.Municipio);
                archivo.WriteLine(direccion.Estado);
                archivo.WriteLine(direccion.CP);

                archivo.Close();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("\n -->> No se ha encontrado el directorio para almacenar el archivo");
                Console.WriteLine(e.Message);

                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
    }
}
