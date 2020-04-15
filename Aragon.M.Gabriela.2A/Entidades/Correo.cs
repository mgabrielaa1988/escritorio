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

        #region Metodos
        public Correo()
        {
            this._paquetes = new List<Paquete>();
            this._mockPaquetes = new List<Thread>();
        }

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

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> l = (List<Paquete>)((Correo)elementos)._paquetes;
            StringBuilder sb = new StringBuilder();
            
            foreach (Paquete p in l)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }

            return sb.ToString();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            bool contienePaquete = false;

            foreach (Paquete item in c.Paquetes)
            {
                if (p == item)
                {
                    contienePaquete = true;
                }
            }

            if (contienePaquete)
            {
                throw new TrackingIdRepetidoException("No. de trackingID ya existente");
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
