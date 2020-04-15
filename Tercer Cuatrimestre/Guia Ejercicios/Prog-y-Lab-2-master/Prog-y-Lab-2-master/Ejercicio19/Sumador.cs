using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    public class Sumador
    {
        private int _cantidadSumas;

        public Sumador():this(0)
        {

        }

        public Sumador(int cantidadSumas)
        {
            this._cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            return a+b;
        }

        public string Sumar(string a, string b)
        {
            return a + b;
        }

        public static implicit operator long(Sumador cantidad)
        {
            return cantidad._cantidadSumas;
        }

        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return sumador1._cantidadSumas + sumador2._cantidadSumas;
        }

        public static bool operator |(Sumador sumador1,Sumador sumador2)
        {
            bool retorno = false;
            if (sumador1._cantidadSumas == sumador2._cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
