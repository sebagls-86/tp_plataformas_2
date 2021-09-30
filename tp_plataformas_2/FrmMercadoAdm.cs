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
    public partial class FrmMercadoAdm : Form
    {
        Mercado mercado = new Mercado();
        public FrmMercadoAdm()
        {
            InitializeComponent();
            string[] categorias = new string[10];

            //mercado.AgregarCategoria("ani");
            //mercado.AgregarCategoria("marcos");
            //mercado.AgregarCategoria("seba");
            mercado.AgregarCategoria("ema");

            //categorias = mercado.MostrarCategorias();
            //for (int i = 0; i < categorias.Length; i++)
            //{
            //    int row = i + 1;
            //    int fila = dataTableCategorias.Rows.Add();
            //    dataTableCategorias.Rows[fila].Cells[0].Value = row;
            //    dataTableCategorias.Rows[fila].Cells[1].Value = categorias[i];

            //}

        }



        private void FrmMercadoAdmin_Load(object sender, EventArgs e)
        {
            lblMainTitle.Text = "";
        }
        

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            panelCompras.Visible = false;
            panelUsuarios.Visible = false;
            panelProductos.Visible = false;
            panelCategorias.Visible = true;
            panelMuestraCategoria.Visible = true;

            lblMainTitle.Text = "Categorias";

            Categoria[] categorias;

            //mercado.AgregarCategoria("ani");
            //mercado.AgregarCategoria("marcos");
            //mercado.AgregarCategoria("seba");
            //mercado.AgregarCategoria("ema");
            categorias = mercado.MostrarCategorias();
            dataTableCategorias.DataSource = categorias;
            
            //dataTableCategorias.DataSource = categorias[0];
            //for (int i = 0; i < categorias.Length; i++)
            //{
            //    if (categorias[i] != null)
            //    {
            //        int row = i + 1;
            //        int fila = dataTableCategorias.Rows.Add();
            //        dataTableCategorias.Rows[fila].Cells[0].Value = row;
            //        dataTableCategorias.Rows[fila].Cells[1].Value = categorias[i];

            //    }

            //}

        }



    

        private void btnProductos_Click(object sender, EventArgs e)
        {
            panelCompras.Visible = false;
            panelUsuarios.Visible = false;
            panelCategorias.Visible = false;
            panelProductos.Visible = true;
            lblMainTitle.Text = "Productos";

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            panelUsuarios.Visible = false;
            panelCategorias.Visible = false;
            panelProductos.Visible = false;
            panelCompras.Visible = true;
            lblMainTitle.Text = "Compras";

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            panelCategorias.Visible = false;
            panelProductos.Visible = false;
            panelCompras.Visible = false;
            panelUsuarios.Visible = true;
            lblMainTitle.Text = "Usuarios";

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain FrmMain = new FrmMain();
            FrmMain.Show();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            panelMuestraCategoria.Visible = false;
            panelAgregarCategoria.Visible = true;
        }

        private void dataTableCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string categoriaNueva = txtboxNombreCategoria.Text;
            bool istrue = mercado.AgregarCategoria(categoriaNueva);
            if (istrue)
            {
                txtboxNombreCategoria.Text = " ";

            }
            //mercado.AgregarCategoria("carnes1");
            //mercado.AgregarCategoria("carnes2");
            //mercado.AgregarCategoria("carnes3");
            //mercado.AgregarCategoria("carnes4");
            //mercado.AgregarCategoria("carnes5");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
