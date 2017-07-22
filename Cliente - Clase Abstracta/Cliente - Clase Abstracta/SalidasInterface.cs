using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente___Clase_Abstracta
{
    public interface SalidasInterface
    {
        void ImprimeCliente(ClienteAbstracta cliente);

        void ImprimeDireccion(Direcciones direccion);
    }
}
