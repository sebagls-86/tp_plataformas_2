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
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain VtnaMain = new FrmMain();
            VtnaMain.Show();
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            cargandoMain.Minimum = 1;
            cargandoMain.Maximum = 100;
            cargandoMain.Step = 1;

            for (int i = 0; i < 100; i++)
            {
                cargandoMain.PerformStep();
            }

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string cuil = txtCuil.Text;
            string mail = txtMail.Text;
            string password = txtPassword.Text;

            MessageBox.Show("Usuario creado con exito");
        }

        private void cargandoMain_Click(object sender, EventArgs e)
        {

        }
    }
}
