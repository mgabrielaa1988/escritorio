using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Tinta
    {
        #region Atributos
        private ConsoleColor _color;
        private ETipoTinta _tipo;
        #endregion

        #region Constructores
        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.ConBrillito;
        }

        public Tinta(ConsoleColor otroColor) : this()
        {
            this._color = otroColor;
        }

        public Tinta(ConsoleColor color,ETipoTinta otraTinta):this(color)
        {
            this._tipo = otraTinta;
        }
        #endregion

        #region Metodos
        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        private string Mostrar()
        {
            return this._tipo.ToString() + " / " + this._color.ToString();
        }
        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Tinta tinta1,Tinta tinta2)
        {
            bool retorno = false;
            if (Object.Equals(tinta1, tinta2))
            {
                if ((tinta1._color == tinta2._color) && (tinta1._tipo == tinta2._tipo))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }
        #endregion
    }
}
