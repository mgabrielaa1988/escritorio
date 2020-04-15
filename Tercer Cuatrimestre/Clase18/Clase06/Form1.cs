using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06
{
    public partial class Form1 : Form
    {
        #region Atributos
        private Ejercicio05.Pluma _pluma;
        private Ejercicio05.Tinta _tinta;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void tintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTinta form = new frmTinta();
            form.Show();
        }
    }
}
