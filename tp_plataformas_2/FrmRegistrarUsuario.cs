using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_plataformas_2.Clases;


namespace tp_plataformas_2
{
    public partial class FrmRegistrarUsuario : Form
    {
        Mercado mercado = new Mercado();

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
            string tipoUsuario = txtDni.Text;
            string cuil = txtCuil.Text;
            string mail = txtMail.Text;
            string password = txtPassword.Text;




            try
            {
                if (nombre == "" || apellido == "" || cuil == "" || mail == "" || password == "" || tipoUsuario == "")

                {
                    throw new Excepciones("Por favor complete todos los campos");

                }

                else
                {

                    try
                    {
                        int cuitI = Int32.Parse(cuil);
                        int tipoUsuarioI = Int32.Parse(tipoUsuario);



                        mercado.AgregarUsuario(cuitI, nombre, apellido, mail, password, tipoUsuarioI);
                        
                        MessageBox.Show("Usuario creado con exito");

                        FrmMain VtnaConfiguracion = new FrmMain();
                        VtnaConfiguracion.Show();

                        this.Hide();

                    }
                    catch (FormatException)
                    {

                        MessageBox.Show("El cuit y tipo de usuario deben ser numericos");
                    }

                }

            }
            catch (Excepciones ex)
            {

                MessageBox.Show(ex.Message);
                
            }

         }

        private void cargandoMain_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
