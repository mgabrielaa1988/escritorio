using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public enum EEstado
    {
        Ingresado,
        EnViaje,
        Entregado
    }


    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegadoEstado(object sender, EventArgs e);

        public event DelegadoEstado InformaEstado;

        private string _direccionEntrega;
        private EEstado _estado;
        private string _trackingID;

        #region Propiedades
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
        
        #region Metodos
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.Estado = EEstado.Ingresado;
        }

        public void MockCicloDeVida()
        {
            while (this.Estado != EEstado.Entregado)
            {
                Thread.Sleep(2000);

                switch (this.Estado)
                {
                    case EEstado.Ingresado:
                        this.Estado = EEstado.EnViaje;
                        break;
                    case EEstado.EnViaje:
                        this.Estado = EEstado.Entregado;
                        break;
                }

                this.InformaEstado(this, new EventArgs());
            }
            PaqueteDAO.Insertar(this);
        }

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
        #endregion
    }
}
