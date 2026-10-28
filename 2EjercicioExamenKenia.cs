using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2EjercicioExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Ingreselanota(double nota)
        {
            if (nota >= 90)
            {
                return "Excelente";
            }
            else if (nota >= 80)
            {
                return "Muy bueno";
            }
            else if (nota >= 70)
            {
                return "Bueno";
            }
            else if (nota >= 60)
            {
                return "Regular";
            }
            else
            {
                return "Deficiente";
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double nota;

            if (!double.TryParse(txtNota.Text, out nota) ||
                nota < 0 || nota > 100)
            {
                MessageBox.Show("Ingrese una nota entre 0 y 100");
            }
            else
            {
                string categoria = Ingreselanota(nota);

                lblResultado.Text = "Resultado: " + categoria;

                if (nota >= 90)
                {
                    lblResultado.BackColor = Color.LightGreen;
                }
                else if (nota < 60)
                {
                    lblResultado.BackColor = Color.LightCoral;
                }
                else
                {
                    lblResultado.BackColor = SystemColors.Control;
                }

                listBoxCategorias.SelectedItem = categoria;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota.Clear();
            lblResultado.Text = "";
            lblResultado.BackColor = SystemColors.Control;
            listBoxCategorias.ClearSelected();
            txtNota.Focus();
        }
    }
}
