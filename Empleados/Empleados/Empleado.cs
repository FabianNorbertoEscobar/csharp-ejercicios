using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Empleado
    {
        private string _nombre;
        private decimal _sueldoDiario;
        private int _edad;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public decimal SueldoDiario
        {
            get { return _sueldoDiario; }
            set { _sueldoDiario = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public Empleado()
        {
            _nombre = string.Empty;
            _sueldoDiario = 0.0m;
            _edad = 0;
        }

        public decimal CalcularSueldo(int NumeroDias)
        {
            return _sueldoDiario * NumeroDias;
        }
    }
}
