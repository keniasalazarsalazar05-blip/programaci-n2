using System;
using System;
using System.Windows.Forms;

namespace _4jercicioExamenKenia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            double precio = 0;
            bool correcto = true;

            if (txtCodigo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCodigo, "Ingrese el código");
                correcto = false;
            }

            if (txtNombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
                correcto = false;
            }

            if (!double.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                errorProvider1.SetError(
                    txtPrecio,
                    "Ingrese un precio mayor que cero"
                );

                correcto = false;
            }

            if (correcto == true)
            {
                Producto producto = new Producto();

                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Precio = precio;

                MessageBox.Show(
                    "Código: " + producto.Codigo +
                    "\nNombre: " + producto.Nombre +
                    "\nPrecio: ₡" + producto.Precio.ToString("N2") +
                    "\nPrecio con IVA: ₡" +
                    producto.ObtenerPrecioConIVA().ToString("N2"),
                    "Datos del producto");
            }
        }
    }
    
            
   

