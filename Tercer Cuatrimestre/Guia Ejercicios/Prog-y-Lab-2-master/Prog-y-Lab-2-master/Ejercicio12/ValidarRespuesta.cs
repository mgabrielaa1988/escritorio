using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        public static bool ValidarS_N(string caracter)
        {
            bool retorno = false;
            if (caracter == "s" || caracter == "S")
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
