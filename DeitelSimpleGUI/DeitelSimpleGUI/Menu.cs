using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeitelSimpleGUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void botAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta ventana aparece cuando se presiona el boton");
        }
    }
}
