using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DetalleFacturaProducto.UI.Registros
{
    public partial class ProductosregistroForm : Form
    {
        public ProductosregistroForm()
        {
            InitializeComponent();
        }

        private void ProductosregistroForm_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            ProductoIdtextBox.Clear();
            descripcionTextBox.Clear();
            costoMaskedTextBox.Clear();
            precioMaskedTextBox.Clear();
            CamposVacioserrorProvider.Clear();

            descripcionTextBox.Focus();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                CamposVacioserrorProvider.SetError(descripcionTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(costoMaskedTextBox.Text))
            {
                CamposVacioserrorProvider.SetError(costoMaskedTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(precioMaskedTextBox.Text))
            {
                CamposVacioserrorProvider.SetError(precioMaskedTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }

            return interruptor;
        }

        private Entidades.Productos LlenarCampos()
        {
            Entidades.Productos producto = new Entidades.Productos();

            producto.Descripcion = descripcionTextBox.Text;
            producto.Costo = Convert.ToDouble(costoMaskedTextBox.Text);
            producto.Precio = Convert.ToDouble(precioMaskedTextBox.Text);

            return producto;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Entidades.Productos producto = new Entidades.Productos();

            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios.");
            }
            else
            {
                producto = LlenarCampos();

                if (BLL.ProductosBLL.Guardar(producto))
                    MessageBox.Show("Producto guardado con exito.");
            }

            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductoIdtextBox.Text))
            {
                MessageBox.Show("El Id a evaluar esta vacio.");
            }
            else
            {
                Entidades.Productos producto = new Entidades.Productos();
                int id = Utilidades.TOINT(ProductoIdtextBox.Text);

                producto = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

                if (producto != null)
                {
                    descripcionTextBox.Text = producto.Descripcion;
                    costoMaskedTextBox.Text = producto.Costo.ToString();
                    precioMaskedTextBox.Text = producto.Precio.ToString();
                }
                else
                {
                    Limpiar();
                    MessageBox.Show("No existe producto con ese id.");
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Hay campos vacios");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(ProductoIdtextBox.Text);

                if (BLL.ProductosBLL.Eliminar(BLL.ProductosBLL.Buscar(p => p.ProductoId == id)))
                {
                    Limpiar();
                    MessageBox.Show("El producto se elimino con exito.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto.");
                }
            }
        }
    }
}
