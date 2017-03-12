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
    public partial class FacturasResgistroForm : Form
    {
        Entidades.Facturas factura;

        public FacturasResgistroForm()
        {
            InitializeComponent();
            Limpiar();
        }

        private void FacturasResgistroForm_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void Limpiar()
        {
            factura = new Entidades.Facturas();

            facturaIdTextBox.Clear();
            fechaDateTimePicker.Value = DateTime.Today;
            costoMaskedTextBox.Clear();
            precioMaskedTextBox.Clear();
            importeMaskedTextBox.Clear();
            cantidadNumericUpDown.Value = 0;
            CamposVacioserrorProvider.Clear();
            DetalledataGridView.DataSource = null;
            productosComboBox.Text = null;
        }

        private bool Validar()
        {
            bool interruptor = true;

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
            if (string.IsNullOrEmpty(importeMaskedTextBox.Text))
            {
                CamposVacioserrorProvider.SetError(importeMaskedTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(productosComboBox.Text))
            {
                CamposVacioserrorProvider.SetError(productosComboBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }

            return interruptor;
        }

        private void LlenarCombo()
        {
            List<Entidades.Productos> lista = BLL.ProductosBLL.ListaTodo();

            productosComboBox.DataSource = lista;
            productosComboBox.DisplayMember = "Descripcion";
            productosComboBox.ValueMember = "ProductoId";

            if (productosComboBox.Items.Count >= 1)
                productosComboBox.SelectedIndex = -1;
        }

        private Entidades.Facturas LlenarCampos()
        {
            string producto = productosComboBox.SelectedValue.ToString();

            factura.Costo = Convert.ToDouble(costoMaskedTextBox.Text);
            factura.Fecha = fechaDateTimePicker.Value;
            factura.Precio = Convert.ToDouble(precioMaskedTextBox.Text);
            factura.Cantidad = cantidadNumericUpDown.Value;
            factura.Importe = Convert.ToDouble(importeMaskedTextBox.Text);
            factura.ProductoId = Utilidades.TOINT(producto);

            return factura;
        }

        private void LlenarGrid(Entidades.Facturas factura)
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = factura.Productos;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios.");
            }
            else
            {
                factura = LlenarCampos();

                if (BLL.FacturasBLL.GuardarBLL(factura))
                    MessageBox.Show("Factura Guardada.");
                else
                    MessageBox.Show("No se guardo.");
            }

            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(facturaIdTextBox.Text))
            {
                MessageBox.Show("El id a evaluar esta vacio.");
            }
            else
            {
                var factura = BLL.FacturasBLL.Buscar(Utilidades.TOINT(facturaIdTextBox.Text));

                //int id = Utilidades.TOINT(facturaIdTextBox.Text);

                //var factura = BLL.FacturasBLL.Buscar(p => p.FacturaId == id);

                if (factura != null)
                {
                    costoMaskedTextBox.Text = factura.Costo.ToString();
                    precioMaskedTextBox.Text = factura.Precio.ToString();
                    cantidadNumericUpDown.Value = factura.Cantidad;
                    fechaDateTimePicker.Value = factura.Fecha;
                    importeMaskedTextBox.Text = factura.Importe.ToString();
                    productosComboBox.SelectedValue = factura.ProductoId;

                    LlenarGrid(factura);
                }
                else
                {
                    MessageBox.Show("No existe Factura con ese id.");
                }
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Entidades.Productos producto = new Entidades.Productos();

            producto = (Entidades.Productos)productosComboBox.SelectedItem;
            factura.Productos.Add(producto);

            LlenarGrid(factura);
        }
    }
}
