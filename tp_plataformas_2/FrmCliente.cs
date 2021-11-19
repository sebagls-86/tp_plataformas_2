using System;
using System.Windows.Forms;

namespace tp_plataformas_2
{
    public partial class FrmCliente : Form
    {

        Mercado Mercado { get; set; }
        Usuario Usuario { get; set; }

        public FrmCliente(Usuario usuario)
        {
            Usuario = usuario;
            Mercado = new Mercado();
            InitializeComponent();
            lblCantidadProductosEnCarro.Text = "" + usuario.Carro.Carro_productos.Count;
        }

        public FrmCliente(Mercado mercado, Usuario usuario)
        {
            Usuario = usuario;
            Mercado = mercado;
            InitializeComponent();

           lblCantidadProductosEnCarro.Text = ""+ Mercado.mostrarCarroPantalla(usuario.UsuarioId).Count;
            

            dgvCategorias.Rows.Clear();

            foreach (Categoria cat in Mercado.todasCategorias())
                dgvCategorias.Rows.Add(cat.toArray());

            dgvCategorias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCategorias.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



            dgvProductos.Rows.Clear();

            foreach (Producto prod in Mercado.todosProductos())
                dgvProductos.Rows.Add(prod.ProductoId, prod.Nombre, prod.Precio, prod.Cantidad, prod.CatId);

            dgvProductos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProductos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain VtnaMain = new FrmMain(Mercado);
            VtnaMain.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBuscar_Click(object sender, EventArgs e)
        {
            string productoBuscar = txtBuscarProductos.Text.ToUpper();
            txtBuscarProductos.Text = "";
            
            dgvProductos.Rows.Clear();

            foreach (Producto prod in Mercado.BusquedaProductos(productoBuscar))
                dgvProductos.Rows.Add(prod.ProductoId, prod.Nombre, prod.Precio, prod.Cantidad, prod.CatId);

        }

        private void pbCarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCheckOut VtnaFrmCheckOut = new FrmCheckOut(Mercado,Usuario);
            VtnaFrmCheckOut.Show();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AGREGAR_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvCategorias_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String nombre = "" + dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
            Categoria categoria = Mercado.BuscarCategoriaPorNombre(nombre);
           
            dgvProductos.Rows.Clear();

            foreach (Producto prod in Mercado.MostrarProductoEnPantallaPorCategoria(categoria.CatId))
                dgvProductos.Rows.Add(prod.ProductoId, prod.Nombre, prod.Precio, prod.Cantidad, prod.CatId);

        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
           
            String nombre = "" + dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            Producto producto = Mercado.BuscarProductoPorNombre(nombre);

            FrmDetalleProducto VtnaDetalleProducto = new FrmDetalleProducto(Mercado, producto, Usuario);
            VtnaDetalleProducto.Show();
        }

        private void comboOrdenarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdenarProductos_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = comboOrdenarProductos.SelectedIndex;
           
            dgvProductos.Rows.Clear();

            foreach (Producto prod in Mercado.MostrarProductosOrdenados(indiceSeleccionado))
                dgvProductos.Rows.Add(prod.ProductoId, prod.Nombre, prod.Precio, prod.Cantidad, prod.CatId);

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            comboOrdenarProductos.SelectedIndex = 0;
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
