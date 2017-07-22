using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();

            empleado.Nombre = "Hernán Fernández";
            empleado.SueldoDiario = 250.00m;
            empleado.Edad = 25;

            decimal total = empleado.CalcularSueldo(30);

            Console.WriteLine("El sueldo mensual del empleado " + empleado.Nombre + "es $" + total);

            Console.ReadKey();
        }
    }
}
