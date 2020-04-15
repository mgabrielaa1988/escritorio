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

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Toma los datos ingresados, realiza la operacion y devuelve el resultado
        /// </summary>
        /// <param name="num1">primer operando</param>
        /// <param name="num2">segundo operando</param>
        /// <param name="operador">caracter que indica la operacion a realizar (+ - / *)</param>
        /// <returns>retorna un double con el resultado de la operacion</returns>
        private static double Operar(string num1, string num2, string operador)
        {
            Numero numero1 = new Numero(num1);
            Numero numero2 = new Numero(num2);
            return Calculadora.Operar(numero1, numero2, operador);
        }

        /// <summary>
        /// Confirma la operacion y muestra el resultado de la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado = "";
            resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
            this.lblResultado.Text = resultado;
        }

        /// <summary>
        /// Convierte el resultado mostrado de decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }

        /// <summary>
        /// Convierte el resulta mostrado de binario a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
        }

        /// <summary>
        /// Limpia el contenido de los textboxs, el combobox y el label de resultado
        /// </summary>
        private void Limpiar()
        {
            this.lblResultado.Text="";
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.ResetText();
        }

        /// <summary>
        /// Reinicia la calculadora 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Cierra la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
