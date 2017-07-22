using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ClienteBase : ClienteAbstracta
    {
        public override int IdCliente { get; set; }

        public override string Nombre { get; set; }

        public override string Clave { get; set; }

        public override string RFC { get; set; }

        public override int TipoRegimen { get; set; }

        public override string NombreContacto { get; set; }

        public ClienteBase()
        {
            IdCliente = 0;
            Nombre = string.Empty;
            Clave = string.Empty;
            RFC = string.Empty;
            TipoRegimen = 0;
            NombreContacto = string.Empty;
        }

        public ClienteBase(int IdCliente, string Nombre, string Clave, string RFC, int TipoRegimen, string NombreContacto)
        {
            this.IdCliente = IdCliente;
            this.Nombre = Nombre;
            this.Clave = Clave;
            this.RFC = RFC;
            this.TipoRegimen = TipoRegimen;
            this.NombreContacto = NombreContacto;
        }
    }
}
