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
    public partial class Form1 : Form
    {
        Paleta paleta;

        public Form1()
        {
            InitializeComponent();
            paleta = 5;
            this.groupBox1.Text = "Paleta de Colores";
            this.textBox1.Multiline = true;
            this.button1.Text = "+";
            this.button2.Text = "-";   
        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.agregarPaletaToolStripMenuItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempera frmTempera = new frmTempera();
            DialogResult result = frmTempera.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.paleta += frmTempera.MiTempera;
                this.textBox1.Text = (string)paleta;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string seleccionado = textBox1.SelectedText;
            int indice = 0;
            foreach(string item in this.textBox1.Lines)
            {
                if (seleccionado == item)
                {
                    frmTempera selectTempera = new frmTempera();
                    break;
                }
                indice++;
            }
            seleccionado = "Selecciono: " +seleccionado + " \nIndice: " + indice.ToString();
            MessageBox.Show(seleccionado);
            
        }
    }
}
