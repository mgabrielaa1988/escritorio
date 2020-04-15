using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesClase2410
{
    public class Carreta:Vehiculo,IARBA
    {
        public Carreta(double precio) : base(precio) { }

        double IARBA.CalcularImpuesto()
        {
            return (this._precio * 0.18);
        }
    }
}
