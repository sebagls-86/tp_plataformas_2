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
    public partial class FrmMercadoAdm : Form
    {
        Mercado Mercado { get; set; }

        public FrmMercadoAdm()
        {

            InitializeComponent();

        }
        public FrmMercadoAdm(Mercado mercado)
        {
            Mercado = mercado;
            InitializeComponent();

        }


        private void FrmMercadoAdmin_Load(object sender, EventArgs e)
        {
            lblMainTitle.Text = "AMB Mercado";
        }


        private void btnCategorias_Click(object sender, EventArgs e)
        {
            panelCompras.Visible = false;
            panelUsuarios.Visible = false;
            panelProductos.Visible = false;
            panelCategorias.Visible = true;
            //panelMuestraCategoria.Visible = true;

            /* --- Titulo Principal ---*/
            lblMainTitle.Text = "Categorias";

            /* --- DataTableGrid ---*/
            dataTableCategorias.DataSource = Mercado.MostrarCategorias();
            dataTableCategorias.Width = 300;

            dataTableCategorias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataTableCategorias.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTableCeliminar.DataSource = Mercado.MostrarCategorias();
            dataTableCeliminar.Width = 300;

            dataTableCeliminar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataTableCeliminar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }


        private void btnProductos_Click(object sender, EventArgs e)
        {
            panelCompras.Visible = false;
            panelUsuarios.Visible = false;
            panelCategorias.Visible = false;
            panelProductos.Visible = true;
            lblMainTitle.Text = "Productos";

            dgvProductos.DataSource = Mercado.MostrarProductoEnPantalla();
            //dgvProductos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvProductos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            panelUsuarios.Visible = false;
            panelCategorias.Visible = false;
            panelProductos.Visible = false;
            panelCompras.Visible = true;
            lblMainTitle.Text = "Compras";

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            panelCategorias.Visible = false;
            panelProductos.Visible = false;
            panelCompras.Visible = false;
            panelUsuarios.Visible = true;
            lblMainTitle.Text = "Usuarios";

            dgvUsuariosLista.DataSource = Mercado.MostrarUsuarios();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain FrmMain = new FrmMain(Mercado);
            FrmMain.Show();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string categoriaNueva = txtboxNombreCategoria.Text;
            if (!categoriaNueva.Equals(""))
            {
                if (Mercado.AgregarCategoria(categoriaNueva))
                {
                    txtboxNombreCategoria.Text = "";
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id;
            bool isParsable = int.TryParse(txtIDCategoriaModificar.Text, out id);
            if (isParsable)
            {
                string nuevoNombre = txtNombreCategoriaModificar.Text;
                Mercado.ModificarCategoria(id, nuevoNombre);
                txtNombreCategoriaModificar.Text = "";
                txtIDCategoriaModificar.Text = "";
            }


        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            
            try
            {
                int idEliminado = int.Parse(txtIdEliminar.Text);

                try
                {
                    if (Mercado.EliminarCategoria(idEliminado))
                    {
                        txtIdEliminar.Text = "";
                        this.Refresh();

                    }
                    else
                    {
                        throw new Excepciones("Categoria no encontrada");
                    }

                }
                catch (Excepciones ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("El id debe ser numerico");
            }


        }

            private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMainTitle_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plataformas de Desarrollo");
        }

        private void kimAnastaciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelCompras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {




            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string cuil = txtCuil.Text;
            string mail = txtMail.Text;
            string password = txtPassword.Text;

            int tipoUsuario = 0;

            if (radioEmpresa.Checked)
            {

                tipoUsuario = 2;

            }
            else if (radioCliente.Checked)
            {
                tipoUsuario = 3;
            }
            else
            {
                tipoUsuario = 1;
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
                        int cuitI = Int32.Parse(cuil);
                        try
                        {

                            bool Agrega = Mercado.AgregarUsuario(cuitI, nombre, apellido, mail, password, tipoUsuario);

                            if (Agrega == true)
                            {

                                MessageBox.Show("Usuario creado con exito");

                                txtNombre.Text = "";
                                txtApellido.Text = "";
                                txtCuil.Text = "";
                                txtMail.Text = "";
                                txtPassword.Text = "";

                            }
                            else
                            {
                                throw new Excepciones("CUIT ya ingresado");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (FormatException)
                    {

                        MessageBox.Show("El cuit debe ser numerico");
                    }

                }

            }
            catch (Excepciones ex)
            {

                MessageBox.Show(ex.Message);

            }


        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {


            string id = txtIdEliminaar.Text;

            try
            {
                int idEliminar = Int32.Parse(id);
                try
                {

                    bool Elimina = Mercado.EliminarUsuario(idEliminar);

                    if (Elimina == true)
                    {

                        MessageBox.Show("Usuario eliminado");

                        txtIdEliminaar.Text = "";


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
            catch (FormatException)
            {

                MessageBox.Show("El id debe ser numerico");
            }

            this.Refresh();
        }

        private void panelCategorias_Paint(object sender, PaintEventArgs e)
        {

        }




            private void btnAgregarProducto_Click(object sender, EventArgs e)
            {
                string nombre = txtNombreProductoAgregar.Text;
                double precio = double.Parse(txtPrecioProductoAgregar.Text);
                int cantidad = int.Parse(txtCantidadProductoAgregar.Text);
                int idCategoria = int.Parse(txtIdCategoriaProductoAgregar.Text);

                if (Mercado.AgregarProducto(nombre, precio, cantidad, idCategoria))
                {
                    txtNombreProductoAgregar.Text = "";
                    txtPrecioProductoAgregar.Text = "";
                    txtCantidadProductoAgregar.Text = "";
                    txtIdCategoriaProductoAgregar.Text = "";
                    MessageBox.Show("Producto Agregado");
                }
                else
                {
                    MessageBox.Show("no se agrego");
                }
                dgvProductos.Refresh();
            }
    }
}

