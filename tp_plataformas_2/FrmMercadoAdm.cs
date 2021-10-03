﻿using System;
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

            

        }



        private void FrmMercadoAdmin_Load(object sender, EventArgs e)
        {
            lblMainTitle.Text = "AMB Mercado";
        }
        

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            panelCompras.Visible = false;
            panelUsuarios.Visible = false;
            panelProductos.Visible = false;
            panelCategorias.Visible = true;
            //panelMuestraCategoria.Visible = true;

            /* --- Titulo Principal ---*/
            lblMainTitle.Text = "Categorias";

            /* --- DataTableGrid ---*/
            dataTableCategorias.DataSource = mercado.MostrarCategorias();
            dataTableCategorias.Width = 300;

            dataTableCategorias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataTableCategorias.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTableCeliminar.DataSource = mercado.MostrarCategorias();
            dataTableCeliminar.Width = 300;

            dataTableCeliminar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataTableCeliminar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }


        private void btnProductos_Click(object sender, EventArgs e)
        {
            panelCompras.Visible = false;
            panelUsuarios.Visible = false;
            panelCategorias.Visible = false;
            panelProductos.Visible = true;
            lblMainTitle.Text = "Productos";

            dgvProductos.DataSource = mercado.MostrarProductoEnPantalla();
            //dgvProductos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvProductos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string categoriaNueva = txtboxNombreCategoria.Text;
            if (!categoriaNueva.Equals(""))
            {
                if (mercado.AgregarCategoria(categoriaNueva))
                {
                    txtboxNombreCategoria.Text = "";
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id;
            bool isParsable = int.TryParse(txtIDCategoriaModificar.Text, out id);
            if (isParsable)
            {
                string nuevoNombre = txtNombreCategoriaModificar.Text;
                mercado.ModificarCategoria(id, nuevoNombre);
                txtNombreCategoriaModificar.Text = "";
                txtIDCategoriaModificar.Text = "";
            }
            
   
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEliminado = int.Parse(txtIdEliminar.Text);
            mercado.EliminarCategoria(idEliminado);
            txtIdEliminar.Text = "";
            this.Refresh();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMainTitle_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plataformas de Desarrollo");
        }

        private void kimAnastaciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelCompras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProductoAgregar.Text;
            double precio = double.Parse(txtPrecioProductoAgregar.Text);
            int cantidad = int.Parse(txtCantidadProductoAgregar.Text);
            int categoriaID = int.Parse(txtIdCategoriaProductoAgregar.Text);

            if(mercado.AgregarProducto(nombre, precio, cantidad, categoriaID))
            {
                MessageBox.Show("producto agregado");
            }
            else
            {
                MessageBox.Show("producto no agregado");

            }
        }
    }
}
