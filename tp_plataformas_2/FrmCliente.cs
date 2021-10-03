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
    public partial class FrmCliente : Form
    {

        Mercado Mercado { get; set; }
        Usuario Usuario { get; set; }

        public FrmCliente(Usuario usuario)
        {
            Usuario = usuario;
            Mercado = new Mercado();
            InitializeComponent();
            lblCantidadProductosEnCarro.Text = "" + usuario.MiCarro.Productos.Count;
        }

        public FrmCliente(Mercado mercado, Usuario usuario)
        {
            Usuario = usuario;
            Mercado = mercado;
            InitializeComponent();
            lblCantidadProductosEnCarro.Text = ""+ usuario.MiCarro.Productos.Count;
            dgvCategorias.DataSource = Mercado.MostrarCategorias();
            dgvProductos.DataSource = Mercado.MostrarProductoEnPantalla();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain VtnaMain = new FrmMain(Mercado);
            VtnaMain.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBuscar_Click(object sender, EventArgs e)
        {
            string productoBuscar = txtBuscarProductos.Text;
            MessageBox.Show("Producto ingresado: " + productoBuscar);
            txtBuscarProductos.Text = "";
        }

        private void pbCarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCheckOut VtnaFrmCheckOut = new FrmCheckOut(Mercado,Usuario);
            VtnaFrmCheckOut.Show();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AGREGAR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Int32 indiceProducto = dgvProductos.Columns.GetColumnCount(DataGridViewElementStates.Selected);
            Producto producto = dgvProductos.SelectedRows[indiceProducto].DataBoundItem as Producto;
            MessageBox.Show("Producto ingresado: " + producto.Nombre);
            FrmDetalleProducto VtnaDetalleProducto = new FrmDetalleProducto(Mercado, producto, Usuario);
            VtnaDetalleProducto.Show();
        }
    }
}
