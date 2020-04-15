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
using ClasesPrincipales;

namespace SimuladorForm
{
    public partial class FrmPpal : Form
    {
        private Correo correo;

        #region "Inicialización y manejo del Formulario"
        /// <summary>
        /// Inicializador para el atributo de tipo Correo y la desactivación de interacción con el usuario del RichTextBox
        /// </summary>
        public FrmPpal()
        {
            InitializeComponent();

            #region "Inicialización de atributo y de RichTextBox"
            this.correo = new Correo();
            this.rtbMostrar.Enabled = false;
            #endregion
        }

        /// <summary>
        /// Se encarga de cerrar todos los hilos activos en caso de que se desee cerrar el formulario
        /// </summary>
        /// <param name="sender">Elemento que desencadena el evento</param>
        /// <param name="e">Información adicional del desencadenante</param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        { this.correo.FinEntregas(); }
        #endregion

        #region "Botones"
        /// <summary>
        /// Agregar: se encarga de crear un nuevo elemento de clase Paquete, intentar agregarlo a la lista _paquetes del atributo de tipo Correo y actualizar los ListBox, captará una excepcion proveniente del operador + en caso de que un elemento sea repetido o en caso de que se presente un error en la base de datos. Tambien agregará el manejador para el evento Informar estado del elemento de tipo Paquete.
        /// </summary>
        /// <param name="sender">Elemento desencadenante</param>
        /// <param name="e">Informacion adicinal sobre el elemento desencadenante</param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete auxPaquete = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);
            auxPaquete.InformarEstado += new Paquete.DelegadoEstado(paq_InformarEstado);

            try
            {
                this.correo += auxPaquete;
                this.ActualizarEstados();
            }
            catch (TrackingIDRepetidoException trackingIDRepetidoException)
            { MessageBox.Show(trackingIDRepetidoException.Message.ToString(), "Alerta", MessageBoxButtons.OK); }
            catch (Exception otherException)
            { MessageBox.Show("Error con la base de Datos", "Alerta", MessageBoxButtons.OK); }
        }

        /// <summary>
        /// Mostrar Todos: Se encarga de mostrar los datos de todos los Paquetes a traves del RichTextBox, sin importar su estado,
        /// </summary>
        /// <param name="sender">Elemento desencadenante</param>
        /// <param name="e">Información adicional sobre el elemento desencadenante</param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        { this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo); }

        #endregion

        #region "Otros controles"
        /// <summary>
        /// Mostrar: Se encarga de mostrar unicamente 1 elemento de tipo Paquete, previamente seleccionado del ListBox de elementos entregados (lstEstadoEntregado)
        /// </summary>
        /// <param name="sender">Elemento desencadenante</param>
        /// <param name="e">Informacion adicional sobre el desencadenante</param>
        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        { this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem); }

        /// <summary>
        /// MouseDown: Muestra el menú contextual para mostrar 1 elemento de tipo Paquete previamente seleccionado de la lista de Entregados (lstEstadoEntregado)
        /// </summary>
        /// <param name="sender">Elemento desencadenante</param>
        /// <param name="e">Información adicional sobre el elemento desencadenante</param>
        private void lstEstadoEntregado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { this.mostrarToolStripMenuItem.Show(MousePosition.X, MousePosition.Y); }
        }
        #endregion

        #region "Métodos No Automáticos"
        /// <summary>
        /// ActualizarEstados: Limpia los ListBox para luego recorrer la lista _paquetes del atributo de tipo Correo para mostrar el cambio de estado de los elementos de tipo Paquete dentro de su lista.
        /// </summary>
        private void ActualizarEstados()
        {
            foreach (Control controlA in this.gBoxPaquetes.Controls)
            {
                if (controlA is ListBox)
                { ((ListBox)controlA).Items.Clear(); }
            }

            foreach (Paquete paqueteA in this.correo.Paquetes)
            {
                switch (paqueteA.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        this.lstEstadoIngresado.Items.Add(paqueteA);
                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(paqueteA);
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(paqueteA);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Manejador para evento de InformarEstado, se encarga de actualizar los ListBox mediante el uso del metodo ActualizarEstados
        /// </summary>
        /// <param name="sender">Elemento desencadenante</param>
        /// <param name="e">Informacion adicional sobre el elemento desencadenante</param>
        void paq_InformarEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformarEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            { this.ActualizarEstados(); }
        }

        /// <summary>
        /// MostrarInformacion: Mostrará la información de un elemento de tipo Paquete o de la lista completa de un elemento de tipoc Correo segun el tipo de su elemento ingresado por parametro. Tambien guardará la informacion obtenida dentro de un archivo en el escritorio de la maquina.
        /// </summary>
        /// <typeparam name="T">Elemento desencadenante</typeparam>
        /// <param name="elemento">INformación adicional sobre el desencadenante</param>
        void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (((object)elemento) != null)
            {
                if (elemento is Correo)
                { this.rtbMostrar.Text = ((Correo)elemento).ToString(); }
                else if (elemento is Paquete)
                { this.rtbMostrar.Text = ((Paquete)elemento).ToString(); }

                this.rtbMostrar.Text.Guardar("salida");
            }
        }
        #endregion
    }
}
