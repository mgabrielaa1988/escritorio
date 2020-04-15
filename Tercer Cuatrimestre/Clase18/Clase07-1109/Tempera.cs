using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07_1109
{
    class Tempera
    {
        private sbyte _cantidad;
        private ConsoleColor _color;
        private string _marca;

        public Tempera(sbyte cantidad, ConsoleColor color,string marca)
        {
            this._cantidad=cantidad;
            this._color=color;
            this._marca=marca;
        }

        private string Mostrar()
        {
            return this._marca + " - " + this._color.ToString() + " - " + this._cantidad.ToString();
        }

        public static implicit operator string (Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static explicit operator sbyte(Tempera tempera)
        {
            return tempera._cantidad;
        }

        public static bool operator ==(Tempera tempera1,Tempera tempera2)
        {
            bool retorno = false;
            if (tempera1._color == tempera2._color && tempera1._marca == tempera2._marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Tempera tempera1,Tempera tempera2)
        {
            return !(tempera1._color == tempera2._color && tempera1._marca == tempera2._marca);
        }

        public static Tempera operator +(Tempera tempera,sbyte cantidad)
        {
            tempera._cantidad += cantidad;
            return tempera;
        }

        public static Tempera operator +(Tempera tempera1,Tempera tempera2)
        {
            Tempera retorno=new Tempera(tempera1._cantidad,tempera1._color,tempera1._marca);
            if (tempera1 == tempera2)
            {
                retorno._cantidad += (sbyte)tempera2._cantidad;
            }
            return retorno;
        }
    }
}
