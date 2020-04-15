using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ClasesPrincipales;

namespace Entidades
{
    /// <summary>
    /// IMostrar: Interface que se utilizará como base para mostrar datos de los distintos elementos
    /// </summary>
    /// <typeparam name="T">Elemento de cualquier clase que se le asigne a la interface en el momento de su implementación</typeparam>
    public interface IMostrar<T>
    {
        /// <summary>
        /// MostrarDatos: Metodo que se utilizará como base para mostrar datos de los distintos elementos
        /// </summary>
        /// <param name="elemento">Elemento de cualquier tipo que se le asigne a la interface en el momento de su implementación</param>
        /// <returns>String con los datos del elemento enviado por parametro</returns>
        string MostrarDatos(IMostrar<T> elemento);
    }

    public class Paquete : IMostrar<Paquete>
    {
        private string _direccionEntrega;
        private EEstado _estado;
        private string _trackingID;
        private string _shareData;

        #region "Propiedades"
        /// <summary>
        /// DireccionEntrega: Propiedad utilizada para manipular el atributo _direccionEntrega
        /// </summary>
        public string DireccionEntrega
        {
            get { return this._direccionEntrega; }
            set { this._direccionEntrega = value; }
        }

        /// <summary>
        /// Estado: Propiedad utilizada para manipular el atributo _estado, utiliza el enumerado EEstado
        /// </summary>
        public EEstado Estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }

        /// <summary>
        /// TrackingID: Propiedad utilizada para manipular el atributo _trackingID
        /// </summary>
        public string TrackingID
        {
            get { return this._trackingID; }
            set { this._trackingID = value; }
        }

        /// <summary>
        /// ShareData: usado para determinar si se logró guardar en base de datos
        /// </summary>
        public string ShareData
        { get { this._shareData; } }

        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor paramatrizado de la clase Paquete, automaticamente inicia el atributo de _estado en "Ingresado"
        /// </summary>
        /// <param name="direccionEntrega">Utilizado para manipular el atributo _direccionEntrega</param>
        /// <param name="trackingID">Utilizado para manipular el atributo _trackingID</param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.Estado = EEstado.Ingresado;
            this._shareData = "aGuardar";
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// MockCicloDeVida: Con el Paquete ya inicializado en "Ingresado", esta funcion suspende el Thread por 10 segundos para luego cambiar su estado al siguiente del enumerado, posteriormente invoca al metodo del evento InformarEstado. Esto se hará mientras el estado del Paquete sea diferente a "Entregado".
        /// Como ultimo paso, ingresará el paquete a la base de datos mediante el metodo Insert de PaqueteDAO, en caso de error, lanzará una excepcion.
        /// </summary>
        public void MockCicloDeVida()
        {

            do
            {
                Thread.Sleep(10000);
                this.Estado++;
                this.InformarEstado.Invoke(this, new EventArgs());
            } while (this.Estado != EEstado.Entregado);

            try
            {
                PaqueteDAO.Insert(this);
                this._shareData = "guardado";
            }
            catch (Exception e)
            { this._shareData = "noguardado"; }
        }

        /// <summary>
        /// MostrarDatos: Implementacion para el metodo MostrarDatos de la interface IMostrar
        /// </summary>
        /// <param name="elemento">Elemento de Clase Paquete</param>
        /// <returns>Un string conteniendo los datos del Paquete mediante el uso de un StringBuilder</returns>
        string IMostrar<Paquete>.MostrarDatos(IMostrar<Paquete> elemento)
        {
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.AppendFormat("{0} para {1}", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);

            return stringBuild.ToString();
        }

        #region "Sobrecargas"
        /// <summary>
        /// Sobrecarga del operador == para dos elementos de tipo Paquete, tomará en cuenta sus TrackingID para la comparación
        /// </summary>
        /// <param name="p1">Primer elemento de tipo Paquete</param>
        /// <param name="p2">Segundo elemento de tipo Paquete</param>
        /// <returns>Un Boolean que indica si los elementos son iguales (true) o diferentes (false)</returns>
        public static Boolean operator ==(Paquete p1, Paquete p2)
        {
            Boolean retorno = false;

            if (p1.TrackingID == p2.TrackingID)
            { retorno = true; }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador != para dos elementos de tipo Paquete, tomará en cuenta sus TrackingID para la comparación al usar la sobrecarga ya existente del operados == para luego negar el resultado.
        /// </summary>
        /// <param name="p1">Primer elemento de tipo Paquete</param>
        /// <param name="p2">Segundo elemento de tipo Paquete</param>
        /// <returns>Un Boolean que indica si los elementos son diferentes (true) o iguales (false)</returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        { return !(p1 == p2); }

        /// <summary>
        /// Sobrecarga del metodo ToString para mostrar los datos del Paquete actual, utiliza la implementacion del metodo MostrarDatos de la interface IMostrar
        /// </summary>
        /// <returns>Un string conteniendo los datos del Paquete mediante el uso de un StringBuilder</returns>
        public override string ToString()
        { return ((IMostrar<Paquete>)this).MostrarDatos(this); }

        #endregion
        #endregion

        #region "Delegados"
        /// <summary>
        /// Delegado que se utilizará en el formulario para la manipulación de los ListBox mediante este delegado
        /// </summary>
        /// <param name="sender">object que desencadena el evento del delegado</param>
        /// <param name="e">EventArgs que contendrá información adicional del evento</param>
        public delegate void DelegadoEstado(object sender, EventArgs e);

        #endregion

        #region "Eventos"
        /// <summary>
        /// Evento utilizado para instanciar el DelegadoEstado y poder manipular los ListBox del formulario
        /// </summary>
        public event DelegadoEstado InformarEstado;
        #endregion

        #region "Nested Types"
        /// <summary>
        /// Enumerado utilizado para determinar el estado de envio de los elementos de tipo Paquete
        /// </summary>
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        #endregion
    }

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
                try
                {
                    cAux.Paquetes.Add(p1);
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
