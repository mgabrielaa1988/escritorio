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
    public partial class frmTinta : Form
    {
        public frmTinta()
        {
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColor.Items.Add(color);
            }
            this.cboColor.SelectedItem = ConsoleColor.Black;
            this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}
