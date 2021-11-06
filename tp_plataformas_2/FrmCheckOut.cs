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
    public partial class FrmCheckOut : Form
    {
        Mercado Mercado { get; set; }
        Usuario Usuario { get; set; }

        public FrmCheckOut( Usuario usuario)
        {
            InitializeComponent();
            Mercado = new Mercado();
            Usuario = usuario;
        }

        public FrmCheckOut(Mercado mercado,Usuario usuario)
        {
            InitializeComponent();
            Mercado = mercado;
            Usuario = usuario;
            double productoPrecio = 0;
            List<Producto> productos = new List<Producto>();
            foreach(Producto producto in Usuario.MiCarro.Productos.Keys)
            {
                productos.Add(producto);
                productoPrecio += producto.Precio * Usuario.MiCarro.Productos[producto];
            }
            dgvProductos.DataSource = productos;
            lblTotalPrecio.Text = "$" + productoPrecio;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente VtnaFrmCliente = new FrmCliente(Mercado,Usuario);
            this.Hide();
            VtnaFrmCliente.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                bool sePudoComprar = Mercado.Comprar(Usuario.UsuarioId);
                if (sePudoComprar)
                {
                    MessageBox.Show("Se compraron los productos exitosamente.");
                    FrmCliente frmCliente = new FrmCliente(Mercado, Usuario);
                    this.Hide();
                    frmCliente.Show();

                } else
                {
                    MessageBox.Show("Ha ocurrido un error en la compra");
                }
            }catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool seVacio = Mercado.VaciarCarro(Usuario.UsuarioId);
                if (!seVacio)
                {
                    MessageBox.Show("No se pudo vaciar el carro, ocurrio un problema");
                } else
                {
                    MessageBox.Show("Se ha vaciado el carro.");
                    this.Hide();
                    FrmCliente frmCliente = new FrmCliente(Mercado, Usuario);
                    frmCliente.Show();
                    lblTotalPrecio.Text = "$0";
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Int32 indiceProducto = dgvProductos.Columns.GetColumnCount(DataGridViewElementStates.Selected);
            Producto producto = dgvProductos.SelectedRows[indiceProducto].DataBoundItem as Producto;
            try
            {
                bool sePudoQuitar = Mercado.QuitarDelCarro(producto.ProductoId, Usuario.MiCarro.Productos[producto], Usuario.UsuarioId);
                
                if (!sePudoQuitar)
                {
                    MessageBox.Show("No se pudo vaciar el carro, ocurrio un problema");
                }
                else
                {
                    dgvProductos.DataSource = null;
                    dgvProductos.DataSource = Mercado.MostrarProductoEnPantalla();
                    MessageBox.Show("Se ha removido el producto del carro.");
                    this.Hide();
                    FrmCliente frmCliente = new FrmCliente(Mercado, Usuario);
                    frmCliente.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
