using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    public class Matriz
    {
        private int[,] matriz;

        public Matriz() 
        {
            matriz = new int[4, 2];
        }

        public void InicializarMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriz[i, j] = 0;
                }
            }
        }

        public void ImprimirMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matriz[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
