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
    public partial class FrmAdministracion : Form
    {
        public FrmAdministracion()
        {
            InitializeComponent();
        }


        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain VtnaMain = new FrmMain();
            VtnaMain.Show();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string opcionSeleccionada = cboAdministracion.Text;            

            Mercado mercado = new Mercado();

          if (opcionSeleccionada.Equals("Alta de categoría"))
            {
                MessageBox.Show(opcionSeleccionada);
            }else if (opcionSeleccionada.Equals("Baja de categoría"))
            {
                MessageBox.Show(opcionSeleccionada);
            }else if (opcionSeleccionada.Equals("Modificación de categoría"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Mostrar categorías que existen en el sistema"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Alta de usuario"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Baja de usuario"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Modificación de usuario"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Mostrar usuarios que existen en el sistema"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Alta de producto"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Baja de producto"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Modificación de producto"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Mostrar productos que existen en el sistema"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Mostrar productos que existen en el sistema ordenados por precio"))
            {
                MessageBox.Show(opcionSeleccionada);
            }
            else if (opcionSeleccionada.Equals("Mostrar productos que existen en el sistema ordenados por categoría"))
            {
                MessageBox.Show(opcionSeleccionada);
            }


        }

    }
}
