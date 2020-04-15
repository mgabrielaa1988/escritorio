using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClasesPrincipales
{
    public class Paquete : IMostrar<Paquete>
    {
        private string _direccionEntrega;
        private EEstado _estado;
        private string _trackingID;

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
            { PaqueteDAO.Insert(this); }
            catch (Exception e) { }
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
}
