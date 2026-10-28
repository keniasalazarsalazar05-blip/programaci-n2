using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3EjercicioExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int precio = 0;

            if (cmbServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un servicio");
            }
            else
            {
                switch (cmbServicio.SelectedIndex)
                {
                    case 0:
                        precio = 15000;
                        break;

                    case 1:
                        precio = 20000;
                        break;

                    case 2:
                        precio = 10000;
                        break;
                }

                MessageBox.Show("El precio del servicio es: ₡" +
                                precio.ToString("N0"));
            }
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbServicio.SelectedIndex = -1;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
