using System;
using System.Windows.Forms;

namespace tp_plataformas_2
{
    public partial class FrmDetalleProducto : Form
    {

        Mercado Mercado { get; set; }
        Usuario Comprador { get; set; }
        Producto Producto { get; set; }
        public FrmDetalleProducto(Producto producto, Usuario comprador)
        {
            Comprador = comprador;
            Mercado = new Mercado();
            InitializeComponent();
        }

        public FrmDetalleProducto(Mercado mercado, Producto producto, Usuario comprador)
        {
                        
            Mercado = mercado;
            Comprador = comprador;
            Producto = producto;
            InitializeComponent();



            lblProductoNombre.Text = "PRODUCTO: " + producto.Nombre;
            lblPrecioProducto.Text = "PRECIO: $" + producto.Precio;
            lblCategoriaProducto.Text = "CATEGORIA: " + producto.Cat.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            bool sePudoParsear = Int32.TryParse(txtCantidadComprar.Text, out cantidad);
            bool sePudoAgregar = false;
            try
            {
                cantidad = Int32.Parse(txtCantidadComprar.Text);
                sePudoAgregar = Mercado.AgregarAlCarro(Producto.ProductoId, cantidad, Comprador.UsuarioId);
                if (sePudoAgregar)
                {
                    MessageBox.Show("PRODUCTO AGREGADO AL CARRO-> \n" + Producto.ToString());
                    this.Hide();
                    FrmCliente VtnaCliente = new FrmCliente(Mercado, Comprador);
                    VtnaCliente.Show();
                } else
                {
                    MessageBox.Show("ERROR AL AGREGAR EL PRODUCTO");
                }
            }
            catch (Excepciones ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCliente VtnaCliente = new FrmCliente(Mercado, Comprador);
            VtnaCliente.Show();
        }


    }
}
