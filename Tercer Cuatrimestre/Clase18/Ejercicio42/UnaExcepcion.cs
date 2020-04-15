using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string msj,Exception inner) : base(msj, inner) { }
    }
}
