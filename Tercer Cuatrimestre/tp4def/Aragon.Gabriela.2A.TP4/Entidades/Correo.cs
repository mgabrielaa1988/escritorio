using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> _mockPaquetes;
        private List<Paquete> _paquetes;

        #region "Propiedades"
        /// <summary>
        /// Propiedad utilizada para manipular el atributo _paquetes, que lleva todos los elementos de tipo Paquete dentro de la clase
        /// </summary>
        public List<Paquete> Paquetes
        {
            get
            {
                return this._paquetes;
            }
            set
            {
                this._paquetes = value;
            }
        }
        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor por defecto, se encarga de Inicializar los atributos de clase List<Paquete> y List<Thread>
        /// </summary>
        public Correo()
        {
            this._paquetes = new List<Paquete>();
            this._mockPaquetes = new List<Thread>();
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// FinEntregas: Aborta todos los Thread presentes en la lista de Threads _mockPaquetes.
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread hilo in this._mockPaquetes)
            {
                if (hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }

        /// <summary>
        /// MostrarDatos: Implementacion del metodo MostrarDatos de la interface IMostrar mediante la utilizacion de un StringBuilder
        /// </summary>
        /// <param name="elemento">Elemento de clase List<Paquete></param>
        /// <returns>String con los datos de todos los elementos de tipo Paquete presentes en la lista _paquetes</returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> paquetes = (List<Paquete>)((Correo)elementos)._paquetes;
            StringBuilder sb = new StringBuilder();
            foreach (Paquete p in paquetes)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador + para agregar un elemento de tipo Paquete a la lista _paquetes de un elemento de tipo Correo y un elemento de tipo Thread a la lista _mockPaquetes, respectivamente. En cason caso de que el elemento ya se encuentre en la lista, lanzará una excepcion y no agregará ningun elemento.
        /// </summary>
        /// <param name="c1">Elemento de tipo Correo</param>
        /// <param name="p1">Elemento de tipo Paquete</param>
        /// <returns>Un elemento de tipo Correo con o sin el nuevo elemento agregado</returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            bool repetido = false;
            foreach (Paquete item in c.Paquetes)
            {
                if (p == item)
                {
                    repetido = true;
                }
            }
            if (repetido)
            {
                throw new TrackingIdRepetidoException("N° de tracking ya existente");
            }
            else
            {
                c.Paquetes.Add(p);
                Thread hiloPaquete = new Thread(p.MockCicloDeVida);
                c._mockPaquetes.Add(hiloPaquete);
                hiloPaquete.Start();
            }
            return c;
        }
        #endregion
    }
}
