using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente___Clase_Abstracta
{
    public class Impresion : SalidasInterface
    {
        public void ImprimeCliente(ClienteAbstracta cliente)
        {
            Console.WriteLine(cliente.IdCliente);
            Console.WriteLine(cliente.Nombre);
            Console.WriteLine(cliente.Clave);
            Console.WriteLine(cliente.RFC);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.NombreContacto);
        }

        public void ImprimeDireccion(Direcciones direccion)
        {
            Console.WriteLine(direccion.Calle);
            Console.WriteLine(direccion.NumeroExterior);
            Console.WriteLine(direccion.NumeroInterior);
            Console.WriteLine(direccion.Colonia);
            Console.WriteLine(direccion.Municipio);
            Console.WriteLine(direccion.Estado);
            Console.WriteLine(direccion.CP);
        }
    }
}
