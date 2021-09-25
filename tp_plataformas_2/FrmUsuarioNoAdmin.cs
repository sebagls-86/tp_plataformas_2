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
    public partial class FrmUsuarioNoAdmin : Form
    {
        public FrmUsuarioNoAdmin()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain VtnaMain = new FrmMain();
            VtnaMain.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            //Probando como agregar filas
            int fila = dgvProductos.Rows.Add();
            //Donde la voy a guardar
            dgvProductos.Rows[fila].Cells[0].Value = txtBuscador.Text;
            dgvProductos.Rows[fila].Cells[1].Value = txtBuscador.Text;
            dgvProductos.Rows[fila].Cells[2].Value = txtBuscador.Text;
            dgvProductos.Rows[fila].Cells[3].Value = txtBuscador.Text;
            dgvProductos.Rows[fila].Cells[4].Value = txtBuscador.Text;
            txtBuscador.Text = "";

        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //El indice de la fila arranca en 0 (e =  parametro del evento)

            int fila = e.RowIndex; //Fila doblecliqueada

            if (fila != -1)
            {
                this.Hide();
                FrmDetalleProducto VtnaFrmDetalleProducto = new FrmDetalleProducto();
                VtnaFrmDetalleProducto.Show();
            }


        }

        private void pbCarro_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
