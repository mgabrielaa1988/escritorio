using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        private Correo _correo;

        public FrmPpal()
        {
            InitializeComponent();

            _correo = new Correo();
            lstEstadoEntregado.ContextMenuStrip = cmsListas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paq = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);

            paq.InformaEstado += paq_InformaEstado;
            try
            {
                _correo += paq;
            }
            catch (TrackingIdRepetidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ActualizarEstados();
            }
        }

        #region Metodos
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }
        }

        private void ActualizarEstados()
        {
            lstEstadoIngresado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoEntregado.Items.Clear();

            foreach (Paquete paq in _correo.Paquetes)
            {
                switch (paq.Estado)
                {
                    case EEstado.Ingresado:
                        lstEstadoIngresado.Items.Add(paq);
                        break;
                    case EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(paq);
                        break;
                    case EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(paq);
                        break;
                }
            }
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (elemento != null)
            {
                rtbMostrar.Text = elemento.MostrarDatos(elemento);
                rtbMostrar.Text.Guardar("salida.txt");
            }
        }
        #endregion

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            _correo.FinEntregas();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)_correo);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}
