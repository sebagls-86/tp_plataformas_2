using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_plataformas_2
{
    public partial class FrmDetalleProducto : Form
    {

        Mercado Mercado { get; set; }

        public FrmDetalleProducto(Producto producto)
        {
            Mercado = new Mercado();
            InitializeComponent();
        }

        public FrmDetalleProducto(Mercado mercado, Producto producto)
        {
            Mercado = mercado;
            InitializeComponent();
            lblProductoNombre.Text = "PRODUCTO: " + producto.Nombre;
            lblPrecioProducto.Text = "PRECIO: $" + producto.Precio;
            lblCategoriaProducto.Text = "CATEGORIA: " + producto.Cat.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mercado.BuscarProductoPorId(txtCantidadComprar.Text);
            }
            catch (Excepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Producto agregado con exito");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCliente VtnaCliente = new FrmCliente(Mercado);
            VtnaCliente.Show();
        }

    }
}
