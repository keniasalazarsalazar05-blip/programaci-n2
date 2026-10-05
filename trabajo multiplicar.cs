using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_multiplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblingreseelsegundonumero_Click(object sender, EventArgs e)
        {

        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtprimernumero.Text);
            double numero2 = double.Parse(txtsegundonumero.Text);

            double resultado = numero1 * numero2;

            MessageBox.Show("El resultado es: " + resultado);
        }
    }
}
