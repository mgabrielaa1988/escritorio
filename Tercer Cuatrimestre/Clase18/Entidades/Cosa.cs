using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cosa
    {
        #region Atributos

        public string cadena;
        public double numero;
        public DateTime fecha;

        #endregion

        #region Constructor
        /// <summary>
        /// Contructor por default de la clase cosa
        /// </summary>
        public Cosa()
        {
            this.cadena = "sin valor";
            this.numero = 1.9;
            this.fecha = DateTime.Now;
        }

        public Cosa(string otraCadena) : this()
        {
            this.cadena = otraCadena;
        }

        #endregion

        #region Mostrar
        /// <summary>
        /// Muestra el contenido de Cosa
        /// </summary>
        /// <param name="otraCosa">...</param>
        /// <returns></returns>
        public static string Mostrar(Cosa otraCosa)
        {
            return otraCosa.Mostrar();
        }

        private string Mostrar()
        {
            return this.cadena + " " + this.numero + " " + this.fecha.ToLongDateString() + "\n";
        }
        #endregion

        #region Establecer Valor
        public void EstablecerValor(string texto)
        {
            this.cadena = texto;
        }

        public void EstablecerValor(DateTime hora)
        {
            this.fecha = hora;
        }

        public void EstablecerValor(double numero)
        {
            this.numero = numero;
        }
        #endregion
    }
}
