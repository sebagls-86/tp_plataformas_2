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
    public partial class FrmCliente : Form
    {

        Mercado Mercado { get; set; }

        public FrmCliente()
        {
            Mercado = new Mercado();
            InitializeComponent();
        }

        public FrmCliente(Mercado mercado)
        {
            Mercado = mercado;
            InitializeComponent();
            dgvCategorias.DataSource = Mercado.MostrarCategorias();
            dgvProductos.DataSource = Mercado.MostrarProductoEnPantalla();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain VtnaMain = new FrmMain();
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

        private void btnTestDetalleProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Producto producto = dgvProductos.SelectedRows[0].DataBoundItem as Producto;
            MessageBox.Show("Producto ingresado: " + producto.Nombre);
            FrmDetalleProducto VtnaDetalleProducto = new FrmDetalleProducto();
            VtnaDetalleProducto.Show();
        }

        private void pbCarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCheckOut VtnaFrmCheckOut = new FrmCheckOut();
            VtnaFrmCheckOut.Show();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
