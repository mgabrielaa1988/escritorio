using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial
{
    public partial class FrmPrincipal : Form
    {
        public ActualizarNombrePorDelegado miDelegado;

        public FrmPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados testDelegados = new frmTestDelegados();
            testDelegados.Show(this);
            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos datos = new frmDatos();
            datos.Show(this);
            this.miDelegado += new ActualizarNombrePorDelegado(datos.ActualizarNombre);
            this.miDelegado.Invoke("Probando");
            
        }
    }
}
