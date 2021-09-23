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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            cargandoMain.Minimum = 1;
            cargandoMain.Maximum = 100;
            cargandoMain.Step = 1;

            for (int i = 0; i < 100; i++)
            {
                cargandoMain.PerformStep();
            }


            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (usuario.Equals("a") && password.Equals("a"))
            {
                MessageBox.Show("Usuario detectado = ADMIN");
                this.Hide();

                FrmPrincipal VtnaPrincipal = new FrmPrincipal();
                VtnaPrincipal.Show();
            }else if (usuario.Equals("u") && password.Equals("u"))
            {
                MessageBox.Show("Usuario tipo usuario - Iria nueva ventana");
            }
            else
            {
                MessageBox.Show("Usuario invalido!");
            }
        }
    }
}
