using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesClase2410
{
    public class Familiar:Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente, int cantAsientos) : base(precio, patente)
        {
            this._cantAsientos = cantAsientos;
        }
    }
}
