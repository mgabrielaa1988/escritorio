using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        #region Atributos
        private double _cantidad;
        private float _cotizRespectoDolar;
        #endregion

        #region Constructores
        public Pesos(double cantidad,float cotizacion)
        {
            this._cantidad = cantidad;
            this._cotizRespectoDolar = cotizacion;
        }

        private Pesos() : this(0, (float)17.55){ }

        public Pesos(double cantidad):this()
        {
            this._cantidad = cantidad;
        }
        #endregion

        #region Gets
        public double GetCantidad()
        {
            return this._cantidad;
        }

        public float GetCotizacion()
        {
            return this._cotizRespectoDolar;
        }
        #endregion

        #region Explicits / Implicit
        public static explicit operator Dolar(Pesos p)
        {
            Dolar dolar = new Dolar(p.GetCantidad() / p.GetCotizacion());
            return dolar;
        }

        public static explicit operator Euro(Pesos p)
        {
            Euro euro1 = new Euro(0);
            Euro euro2 = new Euro(p.GetCantidad() / p.GetCotizacion() / euro1.GetCotizacion());
            return euro2;
        }

        public static implicit operator Pesos (double d)
        {
            Pesos pesos = new Pesos(d);
            return pesos;
        }
        #endregion

        #region Sobrecarga operador ==
        public static bool operator ==(Pesos p, Dolar d)
        {
            bool retorno = false;
            if ((p.GetCantidad()*p.GetCotizacion()) == d.GetCantidad()){
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool retorno = false;
            if ((p.GetCantidad() * p.GetCotizacion()) == (e.GetCantidad() * e.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool retorno = false;
            if (p1.GetCantidad() == p2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region Sobrecarga operador !=
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Sobrecarga operadores + y -
        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos pesos = new Pesos(p.GetCantidad() + (d.GetCantidad() * p.GetCotizacion()));
            return pesos;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos pesos = new Pesos(p.GetCantidad() + (e.GetCantidad() * e.GetCotizacion() * p.GetCotizacion()));
            return pesos;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos pesos = new Pesos(p.GetCantidad() - (d.GetCantidad() * p.GetCotizacion()));
            return pesos;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos pesos = new Pesos(p.GetCantidad() - (e.GetCantidad() * e.GetCotizacion() * p.GetCotizacion()));
            return pesos;
        }
        #endregion
    }

    public class Euro
    {
        #region Atributos
        private double _cantidad;
        private float _cotizRespectoDolar;
        #endregion

        #region Constructores
        public Euro(double cantidad, float cotizacion)
        {
            this._cantidad = cantidad;
            this._cotizRespectoDolar = cotizacion;
        }

        private Euro():this(0,(float)1.3642){}

        public Euro(double cantidad):this()
        {
            this._cantidad = cantidad;
        }
        #endregion

        #region Gets
        public double GetCantidad()
        {
            return this._cantidad;
        }

        public float GetCotizacion()
        {
            return this._cotizRespectoDolar;
        }
        #endregion

        #region Explicits / Implicit
        public static explicit operator Dolar(Euro e)
        {
            Dolar dolar = new Dolar(e.GetCantidad() * e.GetCotizacion());
            return dolar;
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolar dolar = new Dolar(0);
            Pesos pesos = new Pesos(e.GetCantidad() * e.GetCotizacion() * dolar.GetCotizacion());
            return pesos;
        }

        public static implicit operator Euro(double d)
        {
            Euro euro = new Euro(d);
            return euro;
        }
        #endregion

        #region Sobrecarga operador ==
        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;
            if ((e.GetCantidad()*e.GetCotizacion()) == d.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool retorno = false;
            if ((e.GetCantidad() * e.GetCotizacion()) == (p.GetCantidad() * p.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retorno = false;
            if (e1.GetCantidad() == e2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region Sobrecarga operador !=
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        #endregion

        #region Sobrecarga operadores + y -
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro euro = new Euro(e.GetCantidad() + (d.GetCantidad() * e.GetCotizacion()));
            return euro;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro euro = new Euro(e.GetCantidad() + (p.GetCantidad() * p.GetCotizacion() * e.GetCotizacion()));
            return euro;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro euro = new Euro(e.GetCantidad() - (d.GetCantidad() * e.GetCotizacion()));
            return euro;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro euro = new Euro(e.GetCantidad() - (p.GetCantidad() * p.GetCotizacion() * e.GetCotizacion()));
            return euro;
        }
        #endregion
    }

    public class Dolar
    {
        #region Atributos
        private double _cantidad;
        private float _cotizRespectoDolar;
        #endregion

        #region Constructores
        public Dolar(double cantidad, float cotizacion)
        {
            this._cantidad = cantidad;
            this._cotizRespectoDolar = cotizacion;
        }

        private Dolar():this(0,1){}

        public Dolar(double cantidad):this()
        {
            this._cantidad = cantidad;
        }
        #endregion

        #region Gets
        public double GetCantidad()
        {
            return this._cantidad;
        }

        public float GetCotizacion()
        {
            return this._cotizRespectoDolar;
        }
        #endregion

        #region Explicits / Implicit
        public static explicit operator Euro(Dolar d)
        {
            Euro euro1 = new Euro(0);
            Euro euro2 = new Euro(d.GetCantidad() * euro1.GetCotizacion());
            return euro2;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos pesos1 = new Pesos(0);
            Pesos pesos2 = new Pesos(d.GetCantidad() * pesos1.GetCotizacion());
            return pesos2;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);
            return dolar;
        }
        #endregion

        #region Sobrecarga operadores ==
        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;
            if (d.GetCantidad() == (e.GetCantidad() * e.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool retorno = false;
            if (d.GetCantidad() == (p.GetCantidad() * p.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retorno = false;
            if (d1.GetCantidad() == d2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region Sobrecarga operadores !=
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        #endregion

        #region Sobrecarga de operadores + y -
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar(d.GetCantidad() + (e.GetCantidad() * e.GetCotizacion()));
            return dolar;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar dolar = new Dolar(d.GetCantidad() + (p.GetCantidad() * p.GetCotizacion()));
            return dolar;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar(d.GetCantidad() - (e.GetCantidad() * e.GetCotizacion()));
            return dolar;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar dolar = new Dolar(d.GetCantidad() - (p.GetCantidad() * p.GetCotizacion()));
            return dolar;
        }
        #endregion
    }
}
