using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class Numero
    {
        /*Crear el código necesario para lanzar una excepción DivideByZeroException en un método estático,
capturarla en un constructor de instancia y relanzarla hacia otro constructor de instancia que creará
una excepción propia llamada UnaException (utilizar innerException para almacenar la excepción
original) y volver a lanzarla. Luego pasará por un método de instancia que generará una excepción
propia llamada MiException. MiException será capturada en el Main, mostrando el mensaje de
error que esta almacena y los mensajes de todas las excepciones almacenadas en sus
innerException.*/

        public double division;

        public Numero(int a,int b)
        {
            try
            {
                division = Dividir(a,b);
            }
            catch(DivideByZeroException e)
            {
                throw new Exception(e.Message);
            }
        }

        public static double Dividir(int a, int b)
        {
            double retorno = 0;

            if (b != 0)
            {
                retorno = a / b;
            }
            else
            {
                throw new Exception("No se puede dividir por CERO");
            }

            return retorno;
        }
    }
}
