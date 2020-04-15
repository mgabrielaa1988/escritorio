using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void MiManejadorClick(object obj,EventArgs eventArgs)
        {
            MessageBox.Show("Pulsaste: "+ ((Control)obj).Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.button1.Click += new EventHandler(MiManejadorClick);
            //this.button2.Click += new EventHandler(MiManejadorClick);
            //this.textBox1.Click += new EventHandler(MiManejadorClick);
            //this.Click += new EventHandler(MiOtroManejadorClick);
            //this.button1.Click += new EventHandler(CambiarFondo);

            this.button1.Click += new EventHandler(MiManejadorClick);
            this.button1.Click += new EventHandler(ManejadorCentral);
        }

        public void ManejadorCentral(object obj, EventArgs eventArgs)
        {
            if ((Control)obj == this.button1)
            {
                this.button1.Click -= new EventHandler(MiManejadorClick);
                this.button1.Click -= new EventHandler(ManejadorCentral);
                this.button2.Click += new EventHandler(MiManejadorClick);
                this.button2.Click += new EventHandler(ManejadorCentral);
            }
            if ((Control)obj == this.button2)
            {
                this.button2.Click -= new EventHandler(MiManejadorClick);
                this.button2.Click -= new EventHandler(ManejadorCentral);
                this.textBox1.Click += new EventHandler(MiManejadorClick);
                this.textBox1.Click += new EventHandler(ManejadorCentral);
            }
            if ((Control)obj == this.textBox1)
            {
                this.textBox1.Click -= new EventHandler(MiManejadorClick);
                this.textBox1.Click -= new EventHandler(ManejadorCentral);
                this.button1.Click += new EventHandler(MiManejadorClick);
                this.button1.Click += new EventHandler(ManejadorCentral);
            }
        }

        public void MiOtroManejadorClick(object obj, EventArgs eventArgs)
        {
            MessageBox.Show("Pulsaste otro: " + ((Control)obj).Name);
            this.button2.Click -= new EventHandler(MiOtroManejadorClick);
            this.button1.Click += new EventHandler(MiManejadorClick);
        }

        public void CambiarFondo(object obj, EventArgs eventArgs)
        {
            ((Control)obj).BackColor = Color.Aquamarine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Click -= new EventHandler(MiManejadorClick);
            this.button2.Click -= new EventHandler(MiManejadorClick);
            this.textBox1.Click -= new EventHandler(MiManejadorClick);
            this.button1.Click -= new EventHandler(MiManejadorClick);
            this.Click -= new EventHandler(MiOtroManejadorClick);
            this.button1.Click -= new EventHandler(CambiarFondo);
        }
    }
}
