using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz MiMatriz = new Matriz();
            MiMatriz.InicializarMatriz();

            Console.WriteLine("MATRIZ");
            MiMatriz.ImprimirMatriz();

            Console.ReadKey();
        }
    }
}
