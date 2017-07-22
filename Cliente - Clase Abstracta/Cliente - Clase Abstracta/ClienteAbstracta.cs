using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente___Clase_Abstracta
{
    public abstract class ClienteAbstracta
    {
        public abstract int IdCliente { get; set; }

        public abstract string Nombre { get; set; }
        
        public abstract string Clave { get; set; }

        public abstract string RFC { get; set; }

        public abstract int TipoRegimen { get; set; }

        public abstract string NombreContacto { get; set; }

        // las clases que hereden de la clase abstracta deben implementar todos los miembros abstractos
    }
}
