using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DetalleFacturaProducto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UI.Registros.ProductosregistroForm().Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UI.Registros.FacturasResgistroForm().Show();
        }
    }
}
