using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesClase2410
{
    public class Comercial:Avion,IARBA
    {
        protected int _cantidadPasajeros;

        public Comercial(double precio, double velocidad, int pasajeros) : base(precio, velocidad)
        {
            this._cantidadPasajeros = pasajeros;
        }

        double IARBA.CalcularImpuesto()
        {
            return (this._precio * 0.25);
        }
    }
}
