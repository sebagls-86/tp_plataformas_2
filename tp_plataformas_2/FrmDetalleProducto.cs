using System;
using System.Windows.Forms;

namespace tp_plataformas_2
{
    public partial class FrmDetalleProducto : Form
    {
        public FrmDetalleProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productoNombre = lblProductoNombre.Text;
            string precioPorudcto = lblPrecioProducto.Text;
            string productoCategoria = lblCategoriaProducto.Text;
            string cantidadComprar = txtCantidadComprar.Text;

            MessageBox.Show("Producto agregado con exito");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCliente VtnaCliente = new FrmCliente();
            VtnaCliente.Show();
        }
    }
}
