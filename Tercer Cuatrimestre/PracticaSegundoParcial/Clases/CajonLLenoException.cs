using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CajonLlenoException : Exception
    {
        public CajonLlenoException(string mensaje):base(mensaje)
        {
            //Console.WriteLine(mensaje);
        }
    }
}
