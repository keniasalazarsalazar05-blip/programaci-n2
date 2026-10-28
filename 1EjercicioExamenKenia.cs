using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ExamenKenia
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double horas, pago, salario;

            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre del trabajador");
            }
            else if (!double.TryParse(txtHoras.Text, out horas) || horas <= 0)
            {
                MessageBox.Show("Ingrese horas mayores que cero");
            }
            else if (!double.TryParse(txtPago.Text, out pago) || pago <= 0)
            {
                MessageBox.Show("Ingrese un pago por hora mayor que cero");
            }
            else
            {
                if (horas <= 40)
                {
                    salario = horas * pago;
                }
                else
                {
                    salario = (40 * pago) + ((horas - 40) * pago * 1.5);
                }

                lblResultado.Text = "Trabajador: " + nombre +
                                    "\nSalario total: " + salario.ToString("N2");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtHoras.Clear();
            txtPago.Clear();
            lblResultado.Text = "";

            txtNombre.Focus();
        }
    }
}