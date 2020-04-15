using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPrincipales
{
    public class TrackingIDRepetidoException : Exception
    {
        /// <summary>
        /// Constructor parametrizado para la excepcion
        /// </summary>
        /// <param name="mensaje">Mensaje correspondiende de la excepcion</param>
        public TrackingIDRepetidoException(string mensaje) : base(mensaje) { }

        /// <summary>
        /// Constructor parametrizado para la excepcion
        /// </summary>
        /// <param name="mensaje">Mensaje correspondiende de la excepcion</param>
        /// <param name="inner">elemento de tipo Exception para utilizar como excepcion interna</param>
        public TrackingIDRepetidoException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
