using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClasesPrincipales
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Paquete> _paquetes;
        private List<Thread> _mockPaquetes;

        #region "Propiedades"
        /// <summary>
        /// Propiedad utilizada para manipular el atributo _paquetes, que lleva todos los elementos de tipo Paquete dentro de la clase
        /// </summary>
        public List<Paquete> Paquetes
        {
            get { return this._paquetes; }
            set { this._paquetes = value; }
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
            foreach (Thread threadA in this._mockPaquetes)
            { threadA.Abort(); }

            this._mockPaquetes.Clear();
        }

        /// <summary>
        /// MostrarDatos: Implementacion del metodo MostrarDatos de la interface IMostrar mediante la utilizacion de un StringBuilder
        /// </summary>
        /// <param name="elemento">Elemento de clase List<Paquete></param>
        /// <returns>String con los datos de todos los elementos de tipo Paquete presentes en la lista _paquetes</returns>
        string IMostrar<List<Paquete>>.MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            StringBuilder stringBuild = new StringBuilder();

            foreach (Paquete paqueteA in this.Paquetes)
            { stringBuild.AppendFormat("{0} ({1})\n", paqueteA.ToString(), paqueteA.Estado); }

            return stringBuild.ToString();
        }

        #region "Sobrecargas"
        /// <summary>
        /// Sobrecarga del operador == para un elemento de tipo Correo y uno de tipo Paquete, utiliza la sobrecarga del operador == de dos elementos de tipo Paquete para realizar la comparación
        /// </summary>
        /// <param name="c1">Elemento de clase Correo</param>
        /// <param name="p1">Elemento de clase Paquete</param>
        /// <returns>Boolean que indica si el Paquete se encuentra dentro de la lista _paquetes (true) o no se encuentra en ella (false)</returns>
        public static Boolean operator ==(Correo c1, Paquete p1)
        {
            Boolean retorno = false;

            foreach (Paquete paqueteA in c1.Paquetes)
            {
                if (paqueteA == p1)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador != para un elemento de tipo Correo y uno de tipo Paquete, utiliza la sobrecarga del operador == entre un elemento de tipo Correo y uno de tipo Paquete para realizar la comparación y posteriormente negar su resultado
        /// </summary>
        /// <param name="c1">Elemento de clase Correo</param>
        /// <param name="p1">Elemento de clase Paquete</param>
        /// <returns>Boolean que indica si el Paquete NO se encuentra en la lista _paquetes (true) o sí SI se encuentra en ella (false)</returns>
        public static Boolean operator !=(Correo c1, Paquete p1)
        { return !(c1 == p1); }

        /// <summary>
        /// Sobrecarga del operador + para agregar un elemento de tipo Paquete a la lista _paquetes de un elemento de tipo Correo y un elemento de tipo Thread a la lista _mockPaquetes, respectivamente. En cason caso de que el elemento ya se encuentre en la lista, lanzará una excepcion y no agregará ningun elemento.
        /// </summary>
        /// <param name="c1">Elemento de tipo Correo</param>
        /// <param name="p1">Elemento de tipo Paquete</param>
        /// <returns>Un elemento de tipo Correo con o sin el nuevo elemento agregado</returns>
        public static Correo operator +(Correo c1, Paquete p1)
        {
            Correo cAux = c1;

            if (cAux != p1)
            {
                cAux.Paquetes.Add(p1);

                try
                {
                    Thread hiloP1 = new Thread(p1.MockCicloDeVida);
                    cAux._mockPaquetes.Add(hiloP1);
                    hiloP1.Start();
                }
                catch (Exception e)
                { throw e; }

            }
            else
            { throw new TrackingIDRepetidoException("El Tracking ID " + p1.TrackingID + " ya figura en la lista de envios."); }

            return cAux;
        }

        /// <summary>
        /// Sobrecarga del metodo ToString que hace reutilización de la implementacion de la interface IMostrar
        /// </summary>
        /// <returns>String conteniendo los datos de todos los elementos de la lista _paquetes</returns>
        public override string ToString()
        { return ((IMostrar<List<Paquete>>)this).MostrarDatos(this); }

        #endregion
        #endregion
    }
}
