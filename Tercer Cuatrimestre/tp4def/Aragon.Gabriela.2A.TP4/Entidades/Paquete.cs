using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        private string _direccionEntrega;
        private EEstado _estado;
        private string _trackingID;

        #region "Propiedades"
        /// <summary>
        /// DireccionEntrega: Propiedad utilizada para manipular el atributo _direccionEntrega
        /// </summary>
        public string DireccionEntrega
        {
            get
            {
                return this._direccionEntrega;
            }
            set
            {
                this._direccionEntrega = value;
            }
        }

        /// <summary>
        /// Estado: Propiedad utilizada para manipular el atributo _estado, utiliza el enumerado EEstado
        /// </summary>
        public EEstado Estado
        {
            get
            {
                return this._estado;
            }
            set
            {
                this._estado = value;
            }
        }

        /// <summary>
        /// TrackingID: Propiedad utilizada para manipular el atributo _trackingID
        /// </summary>
        public string TrackingID
        {
            get
            {
                return this._trackingID;
            }
            set
            {
                this._trackingID = value;
            }
        }
        #endregion

        #region Constructor
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

        public void MockCicloDeVida()
        {
            do
            {
                System.Threading.Thread.Sleep(5000);
                switch (this.Estado)
                {
                    case EEstado.Ingresado:
                        this.Estado = EEstado.EnViaje;
                        break;
                    case EEstado.EnViaje:
                        this.Estado = EEstado.Entregado;
                        break;
                    default:
                        break;
                }
                this.InformaEstado.Invoke(this, new EventArgs());
            } while (this.Estado != EEstado.Entregado);
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Muestra los datos de un paquete como texto.
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            string retorno = string.Format("{0} para {1}", ((Paquete)elemento)._trackingID, ((Paquete)elemento)._direccionEntrega);
            return retorno;
        }

        public override string ToString()
        {
            return this.MostrarDatos((IMostrar<Paquete>)this);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return p1._trackingID == p2._trackingID;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

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
        public event DelegadoEstado InformaEstado;
        #endregion
    }
}
