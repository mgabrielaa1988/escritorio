using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        #region Atributo
        private string mensajeBase;
        #endregion

        #region Constructores
        public DniInvalidoException() : this("DNI Invalido.")
        {

        }

        public DniInvalidoException(Exception e) : this(e.Message)
        {

        }

        public DniInvalidoException(string message) : base(message)
        {
        }

        public DniInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        #endregion

    }
}
