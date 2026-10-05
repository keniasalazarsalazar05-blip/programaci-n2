using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmsuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtprimernumero.Text);
            double numero2 = double.Parse(txtsegundonumero.Text);

            double resultado = numero1 + numero2;

            MessageBox.Show("El resultado es: " + resultado);
        }
    }
}
