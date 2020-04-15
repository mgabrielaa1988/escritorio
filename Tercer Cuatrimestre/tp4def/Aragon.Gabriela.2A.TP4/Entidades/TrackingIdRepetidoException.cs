using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrackingIdRepetidoException : Exception
    {
        /// <summary>
        /// Constructor parametrizado para la excepcion
        /// </summary>
        /// <param name="mensaje">Mensaje correspondiende de la excepcion</param>
        public TrackingIdRepetidoException(string mensaje) : base(mensaje) { }

        /// <summary>
        /// Constructor parametrizado para la excepcion
        /// </summary>
        /// <param name="mensaje">Mensaje correspondiende de la excepcion</param>
        /// <param name="inner">elemento de tipo Exception para utilizar como excepcion interna</param>
        public TrackingIdRepetidoException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
