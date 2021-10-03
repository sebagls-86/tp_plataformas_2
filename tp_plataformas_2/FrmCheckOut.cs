using System;
using System.Windows.Forms;

namespace tp_plataformas_2
{
    public partial class FrmCheckOut : Form
    {
        public FrmCheckOut()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCliente VtnaFrmCliente = new FrmCliente();
            VtnaFrmCliente.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra realizada con exito");
        }
    }
}
