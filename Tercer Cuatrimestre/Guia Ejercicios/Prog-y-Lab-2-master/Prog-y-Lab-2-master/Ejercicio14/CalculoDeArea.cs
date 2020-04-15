using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            double retorno=Math.Pow(numero,2);
            return retorno;
        }
        public static double CalcularTriangulo(double baseT, double alturaT)
        {
            double retorno=(baseT*alturaT)/2;
            return retorno;
        }
        public static double CalcularCirculo(double radio)
        {
            double retorno = CalcularCuadrado(radio) * Math.PI;
            return retorno;
        }
    }
}
