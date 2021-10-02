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
    public partial class FrmMain : Form
    {
        Mercado mercado = new Mercado();
        public FrmMain()
        {
            
            InitializeComponent();
            
        }

        private void btnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            
            //mercado.AgregarUsuario(123, "seba", "sosa", "seba@sosa", "seba", 1234, false, true);
            //mercado.AgregarUsuario(1234, "seba", "sosa", "seba@sosa", "seba1", 1234, false, false);
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;



            try
            {


                int idUsuario = Int32.Parse(usuario);


                int inicio = mercado.IniciarSesion(idUsuario, password);


                if (inicio != -1)
                {
                   
                    bool Admin = mercado.esAdmin(inicio);

                    if (Admin) { 
                    
                    MessageBox.Show("Usuario detectado = ADMIN");
                    this.Hide();

                    FrmMercadoAdm VtnaPrincipal = new FrmMercadoAdm();
                    VtnaPrincipal.Show();

                    }
                    else if(Admin == false)
                    {
                        MessageBox.Show("¡Gracias por su visita!");
                        this.Hide();

                        FrmCliente VtnCliente = new FrmCliente();
                        VtnCliente.Show();
                    }


                }
                else
                {
                    throw new Excepciones("Usuario no encontrado");
                }
            } 
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfiguracion VtnaConfiguracion = new FrmConfiguracion();
            VtnaConfiguracion.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrarUsuario VtnaRegistrarUsuario = new FrmRegistrarUsuario();
            VtnaRegistrarUsuario.Show();
        }
    }
}
