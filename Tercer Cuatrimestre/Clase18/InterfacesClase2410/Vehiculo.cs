using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesClase2410
{
    public abstract class Vehiculo
    {
        protected double _precio;

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
        
        public void MostrarPrecio()
        {
            Console.WriteLine("El precio es: ${0}\n", this._precio.ToString());
        }
    }
}
