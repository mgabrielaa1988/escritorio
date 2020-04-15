using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesClase2410
{
    public abstract class Auto:Vehiculo
    {
        protected string _patente;

        public Auto(double precio, string patente) : base(precio)
        {
            this._patente = patente;
        }

        public virtual double PropiedadL
        {
            get
            {
                return this._precio;
            }
        }

        public void MostrarPatente()
        {
            Console.WriteLine("Patente: {0}\n", this._patente);
        }
    }
}
