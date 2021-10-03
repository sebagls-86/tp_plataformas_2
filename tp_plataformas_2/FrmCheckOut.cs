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
            List<Producto> productos = new List<Producto>();
            foreach(Producto producto in Usuario.MiCarro.Productos.Keys)
            {
                productos.Add(producto);
            }
            dgvProductos.DataSource = productos;
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
                bool sePudoComprar = Mercado.Comprar(Usuario.Id);
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
    }
}
