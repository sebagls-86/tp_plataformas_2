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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            cargandoMain.Minimum = 1;
            cargandoMain.Maximum = 100;
            cargandoMain.Step = 1;

            for (int i =0; i < 100; i++)
            {
                cargandoMain.PerformStep();
            }

            MessageBox.Show("Ha seleccionado ¡Administracion de productos!");
            this.Hide();

            FrmAdministracion VtnaAdministracion = new FrmAdministracion();
            VtnaAdministracion.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En desarrollo");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
