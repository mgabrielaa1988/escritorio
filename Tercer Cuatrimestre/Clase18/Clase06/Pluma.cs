using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Pluma
    {
        #region Atributos
        private string _marca;
        private int _cantidad;
        private Tinta _tinta;
        #endregion

        #region Constructores
        public Pluma()
        {
            _marca = "sin marca";
            _cantidad = 0;
            _tinta = null;
        }

        public Pluma(string marca):this()
        {
            this._marca = marca;
        }

        public Pluma(int cantidad) : this()
        {
            this._cantidad = cantidad;
        }

        public Pluma(int cantidad,string marca) : this(marca)
        {
            this._cantidad = cantidad;
        }

        public Pluma(Tinta otraTinta,int cant,string marca) : this(cant, marca)
        {
            this._tinta = otraTinta;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            if ((object)this._tinta != null)
            {
                return this._marca.ToString() + " / " + Tinta.Mostrar(this._tinta) + " / " + this._cantidad.ToString();
            }
            return "---";
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Tinta tinta,Pluma tintaPlu)
        {
            return (tinta == tintaPlu._tinta);
        }

        public static bool operator !=(Tinta tinta, Pluma tintaPlu)
        {
            return !(tinta==tintaPlu._tinta);
        }

        public static Pluma operator +(Pluma pluma,Tinta tinta)
        {
            if (pluma._tinta == tinta)
            {
                pluma._cantidad += 10;
                if (pluma._cantidad > 100)
                {
                    pluma._cantidad = 100;
                }
            }
            return pluma;
        }

        public static Pluma operator -(Pluma pluma,Tinta tinta)
        {
            if (pluma._tinta == tinta)
            {
                pluma._cantidad -= 20;
                if (pluma._cantidad < 0){
                    pluma._cantidad = 0;
                }
            }
            return pluma;
        }

        #endregion
    }
}
