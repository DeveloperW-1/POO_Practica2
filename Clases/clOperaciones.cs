using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Practica2
{
    class clOperaciones
    {

        private decimal valor1;
        private decimal valor2;

        public decimal Valor1 { get => valor1; set => valor1 = value; }
        public decimal Valor2 { get => valor2; set => valor2 = value; }

        public clOperaciones()
        {
          
        }

        public decimal suma()
        {
            decimal result = Valor1  + Valor2;
            return result;
        }
        public decimal resta()
        {
            decimal result = valor1 - Valor2;
            return result;
        }
        public decimal multiplicacion()
        {
            decimal result = Valor1 * Valor2;
            return result;
        }
        public decimal division()
        {
            decimal result = Valor1 / Valor2;
            return result;
        }
    }
} 