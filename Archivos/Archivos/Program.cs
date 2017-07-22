using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter archivo;
            archivo = new StreamWriter("archivo.txt");

            Console.WriteLine("\n Ingrese texto a grabar en un archivo:");

            string mensaje = Console.ReadLine();
            archivo.WriteLine(mensaje);

            archivo.Close();
            Console.WriteLine("\n El archivo se ha grabado exitosamente");

            Console.ReadKey();

            TextReader lector;
            lector = new StreamReader("archivo.txt");

            Console.WriteLine("\n Contenido del archivo:");
            Console.WriteLine(lector.ReadToEnd());

            lector.Close();
            Console.WriteLine("\n El archivo se ha cerrado exitosamente");

            StreamWriter escritor = File.AppendText("archivo.txt");

            Console.WriteLine("\n Escriba texto a agregar al archivo:");

            string nuevoTexto = Console.ReadLine();
            escritor.WriteLine(nuevoTexto);

            escritor.Close();
            Console.WriteLine("\n Se ha agregado texto al archivo exitosamente");

            Console.ReadKey();
        }
    }
}
