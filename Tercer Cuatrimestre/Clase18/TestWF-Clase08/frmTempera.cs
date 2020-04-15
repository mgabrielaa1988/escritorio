using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clase07;

namespace TestWF_Clase08
{
    public partial class frmTempera : Form
    {
        private Tempera _miTempera;
        public Tempera MiTempera { get { return this._miTempera; } }

        public frmTempera()
        {
            InitializeComponent();
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cmbColor.Items.Add(color);
            }
            this.cmbColor.SelectedItem = ConsoleColor.Cyan;
            this.cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public frmTempera(Tempera tempera):this()
        {
            
            this.Marca.Text = "";
            this.Cantidad.Text = "";
            this.cmbColor.SelectedItem = "";
            this.cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            this._miTempera = new Tempera(sbyte.Parse(this.txtCantidad.Text),(ConsoleColor)this.cmbColor.SelectedItem,this.txtMarca.Text);
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
