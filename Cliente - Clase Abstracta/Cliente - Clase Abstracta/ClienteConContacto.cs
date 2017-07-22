using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente___Clase_Abstracta
{
    public class ClienteConContacto : ClienteBase
    {
        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Email { get; set; }

        private Direcciones _direccion;

        public Direcciones Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public ClienteConContacto()
        {
            _direccion = new Direcciones();
        }

        public ClienteConContacto(int IdCliente, string Nombre, string Clave, string RFC, 
                                    int TipoRegimen, string NombreContacto, string Telefono1,
                                    string Telefono2, string Email, string Calle,
                                    string NumeroExterior, string Numerointerior,
                                    string Colonia, string Municipio, string Estado, string CP) : this()
        {
            this.IdCliente = IdCliente;
            this.Nombre = Nombre;
            this.Clave = Clave;
            this.RFC = RFC;
            this.TipoRegimen = TipoRegimen;
            this.NombreContacto = NombreContacto;
            this.Telefono1 = Telefono1;
            this.Telefono2 = Telefono2;
            this.Email = Email;

            Direccion.Calle = Calle;
            Direccion.NumeroExterior = NumeroExterior;
            Direccion.NumeroInterior = Numerointerior;
            Direccion.Colonia = Colonia;
            Direccion.Municipio = Municipio;
            Direccion.Estado = Estado;
            Direccion.CP = CP;
        }
    }
}
