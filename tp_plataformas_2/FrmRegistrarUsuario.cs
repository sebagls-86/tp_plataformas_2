using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_plataformas_2;


namespace tp_plataformas_2
{
    public partial class FrmRegistrarUsuario : Form
    {
        Mercado Mercado { get; set; }

        public FrmRegistrarUsuario()
        {
            InitializeComponent();
            //Mercado = new Mercado();
        }

        public FrmRegistrarUsuario(Mercado mercado)
        {
            Mercado = mercado;
            InitializeComponent();
            
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain VtnaMain = new FrmMain(Mercado);
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
            string cuil = txtCuil.Text;
            string mail = txtMail.Text;
            string password = txtPassword.Text;
            int cuilUsuario = 0;
            int tipoUsuario = 0;

            if (radioButton1.Checked)
            {

                tipoUsuario = 2;

            }
            else if (radioButton2.Checked)
            {
                tipoUsuario = 3;
            }

            try
            {
                if (nombre == "" || apellido == "" || cuil == "" || mail == "" || password == "")

                {
                    throw new Excepciones("Por favor complete todos los campos");
                }

                else
                {
                    try
                    {
                        bool esParseable = Int32.TryParse(cuil, out cuilUsuario);
                        if (!esParseable)
                        {
                            throw new Excepciones("El valor ingresado en CUIL no se pudo parsear a INT.");
                        }
                        bool Agrega = Mercado.AgregarUsuario(cuilUsuario, nombre, apellido, mail, password, tipoUsuario);

                        if (Agrega == true)
                        {
                            MessageBox.Show("Usuario creado con exito");

                            FrmMain VtnaConfiguracion = new FrmMain(Mercado);
                            VtnaConfiguracion.Show();

                            this.Hide();

                        }
                        else
                        {
                            throw new Excepciones("CUIT ya ingresado");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
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
