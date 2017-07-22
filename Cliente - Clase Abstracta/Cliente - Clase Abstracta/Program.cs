using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente___Clase_Abstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ClienteAbstracta cliente = new ClienteAbstracta();
            no compila porque no se puede instanciar una clase abstracta
            */

            ClienteBase cliente = new ClienteBase(39210915,"Fabián Norberto","fabnoresc","HEHM",1,"FABNESC");

            ClienteConContacto cliente2 = new ClienteConContacto(39210915, "Fabián Norberto",
                "fabnoresc", "HEHM", 1, "FABNESC", "02202450147", "02202450258",
                "fabiannorbertoescobar@gmail.com", "Riglos 6542", "1551173500", "1558501800",
                "Gregorio de Laferrere", "La Matanza", "Argentina", "1757");
            
            SalidasInterface Salida;

            Salida = new Archivo();

            Salida.ImprimeCliente(cliente2);

            Console.WriteLine("Ejecución del programa exitosa");
            Console.WriteLine(@"Directorio del archivo: Cliente - Clase Abstracta\bin\debug\ArchivoBitacora.log");
            
            Console.ReadKey();
        }
    }
}
