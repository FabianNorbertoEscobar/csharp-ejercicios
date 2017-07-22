using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes___Herencia
{
    public class ClienteVentas : Cliente
    {
        private string _RFC;
        private string _direccion;
        private string _colonia;
        private string _municipio;
        private bool _esCredito;

        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }

        public string Municipio
        {
            get { return _municipio; }
            set { _municipio = value; }
        }

        public bool EsCredito
        {
            get { return _esCredito; }
            set { _esCredito = value; }
        }
    }
}
