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
                       
            dgvProductos.Rows.Clear();

           
            foreach (Carro_productos prod in Mercado.mostrarCarroPantalla(usuario.UsuarioId))
                dgvProductos.Rows.Add(prod.Id_Producto, prod.Producto.Nombre, prod.Cantidad, prod.Producto.Precio, prod.Cantidad* prod.Producto.Precio);


            foreach (Carro_productos prod in Mercado.mostrarCarroPantalla(usuario.UsuarioId))
                productoPrecio += prod.Cantidad * prod.Producto.Precio;


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
                    Mercado.Vaciar(Usuario.UsuarioId);
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

            Mercado.Vaciar(Usuario.UsuarioId);

            MessageBox.Show("Se ha vaciado el carro.");

            this.Hide();
            FrmCliente frmCliente = new FrmCliente(Mercado, Usuario);
            frmCliente.Show();
            lblTotalPrecio.Text = "$0";

            //try
            //{
            //    bool seVacio = Mercado.VaciarCarro(Usuario.UsuarioId);
            //    if (!seVacio)
            //    {
            //        MessageBox.Show("No se pudo vaciar el carro, ocurrio un problema");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Se ha vaciado el carro.");
            //        this.Hide();
            //        FrmCliente frmCliente = new FrmCliente(Mercado, Usuario);
            //        frmCliente.Show();
            //        lblTotalPrecio.Text = "$0";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
           
            string indice = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            int idProd = Int32.Parse(indice);

            Mercado.QuitarDelCarro(idProd, Usuario.UsuarioId);

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Mercado.MostrarProductoEnPantalla();
            MessageBox.Show("Se ha removido el producto del carro.");
            this.Hide();
            FrmCliente frmCliente = new FrmCliente(Mercado, Usuario);
            frmCliente.Show();



            //this.Hide();
            //Int32 indiceProducto = dgvProductos.Columns.GetColumnCount(DataGridViewElementStates.Selected);
            //Producto producto = dgvProductos.SelectedRows[indiceProducto].DataBoundItem as Producto;
            //try
            //{
            //    bool sePudoQuitar = Mercado.QuitarDelCarro(producto.ProductoId, Usuario.Carro.Productos[producto], Usuario.UsuarioId);

            //    if (!sePudoQuitar)
            //    {
            //        MessageBox.Show("No se pudo vaciar el carro, ocurrio un problema");
            //    }
            //    else
            //    {
            //        dgvProductos.DataSource = null;
            //        dgvProductos.DataSource = Mercado.MostrarProductoEnPantalla();
            //        MessageBox.Show("Se ha removido el producto del carro.");
            //        this.Hide();
            //        FrmCliente frmCliente = new FrmCliente(Mercado, Usuario);
            //        frmCliente.Show();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
