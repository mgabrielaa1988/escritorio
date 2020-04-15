using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesClase2410
{
    public class Avion:Vehiculo,IAFIP,IARBA
    {
        protected double _velocidadMaxima;

        public Avion(double precio,double veMaxima) : base(precio)
        {
            this._velocidadMaxima = veMaxima;
        }

        public virtual double PropiedadL
        {
            get
            {
                return this._precio;
            }
        }

        double IAFIP.CalcularImpuesto()
        {
            return (this._precio * 0.33);
        }

        double IARBA.CalcularImpuesto()
        {
            return (this._precio * 0.27);
        }
    }
}
