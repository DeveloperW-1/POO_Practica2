using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Practica2.Clases
{
    public class clFiguras
    {

        private double lado;
        private double altura;

        public double Lado { get => lado; set => lado = value; }
        public double  Altura { get => altura; set => altura = value; }

        public double areaCirculo()
        {
            double result = (Math.Sqrt(Lado)) * 3.1416f;


            return result;
        }
    }
}
