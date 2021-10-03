
namespace tp_plataformas_2
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbCarro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBuscarProductos = new System.Windows.Forms.PictureBox();
            this.comboOrdenarProductos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrdenarProductos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarProductos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidadProductosEnCarro = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTestDetalleProducto = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBuscarProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu,
            this.mnuAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(50, 20);
            this.mnuMenu.Text = "Menu";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Volver";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(71, 20);
            this.mnuAcercaDe.Text = "Acerca de";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Stock,
            this.Categoria});
            this.dgvProductos.Location = new System.Drawing.Point(448, 315);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(542, 293);
            this.dgvProductos.TabIndex = 13;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Producto";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // pbCarro
            // 
            this.pbCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCarro.Image = ((System.Drawing.Image)(resources.GetObject("pbCarro.Image")));
            this.pbCarro.Location = new System.Drawing.Point(1063, 46);
            this.pbCarro.Name = "pbCarro";
            this.pbCarro.Size = new System.Drawing.Size(40, 40);
            this.pbCarro.TabIndex = 15;
            this.pbCarro.TabStop = false;
            this.pbCarro.Click += new System.EventHandler(this.pbCarro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "¡Bienvenido a nuestro Mercado!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(448, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Productos Disponibles";
            // 
            // pictureBuscarProductos
            // 
            this.pictureBuscarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBuscarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBuscarProductos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBuscarProductos.Image")));
            this.pictureBuscarProductos.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBuscarProductos.InitialImage")));
            this.pictureBuscarProductos.Location = new System.Drawing.Point(6, 90);
            this.pictureBuscarProductos.Name = "pictureBuscarProductos";
            this.pictureBuscarProductos.Size = new System.Drawing.Size(31, 29);
            this.pictureBuscarProductos.TabIndex = 20;
            this.pictureBuscarProductos.TabStop = false;
            this.pictureBuscarProductos.Click += new System.EventHandler(this.pictureBuscar_Click);
            // 
            // comboOrdenarProductos
            // 
            this.comboOrdenarProductos.FormattingEnabled = true;
            this.comboOrdenarProductos.Items.AddRange(new object[] {
            "Ordenar Ascendente",
            "Ordenar Descendente"});
            this.comboOrdenarProductos.Location = new System.Drawing.Point(0, 28);
            this.comboOrdenarProductos.Name = "comboOrdenarProductos";
            this.comboOrdenarProductos.Size = new System.Drawing.Size(188, 29);
            this.comboOrdenarProductos.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrdenarProductos);
            this.groupBox1.Controls.Add(this.comboOrdenarProductos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(790, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 125);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar por";
            // 
            // btnOrdenarProductos
            // 
            this.btnOrdenarProductos.Location = new System.Drawing.Point(7, 75);
            this.btnOrdenarProductos.Name = "btnOrdenarProductos";
            this.btnOrdenarProductos.Size = new System.Drawing.Size(111, 32);
            this.btnOrdenarProductos.TabIndex = 22;
            this.btnOrdenarProductos.Text = "Aplicar";
            this.btnOrdenarProductos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarProductos);
            this.groupBox2.Controls.Add(this.pictureBuscarProductos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(448, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 125);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por nombre";
            // 
            // txtBuscarProductos
            // 
            this.txtBuscarProductos.Location = new System.Drawing.Point(6, 43);
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.Size = new System.Drawing.Size(188, 29);
            this.txtBuscarProductos.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(126, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Categorias";
            // 
            // lblCantidadProductosEnCarro
            // 
            this.lblCantidadProductosEnCarro.AutoSize = true;
            this.lblCantidadProductosEnCarro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadProductosEnCarro.Location = new System.Drawing.Point(1104, 33);
            this.lblCantidadProductosEnCarro.Name = "lblCantidadProductosEnCarro";
            this.lblCantidadProductosEnCarro.Size = new System.Drawing.Size(19, 21);
            this.lblCantidadProductosEnCarro.TabIndex = 27;
            this.lblCantidadProductosEnCarro.Text = "0";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvCategorias.Location = new System.Drawing.Point(126, 227);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowTemplate.Height = 25;
            this.dgvCategorias.Size = new System.Drawing.Size(244, 381);
            this.dgvCategorias.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Categoria";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnTestDetalleProducto
            // 
            this.btnTestDetalleProducto.Location = new System.Drawing.Point(490, 386);
            this.btnTestDetalleProducto.Name = "btnTestDetalleProducto";
            this.btnTestDetalleProducto.Size = new System.Drawing.Size(28, 23);
            this.btnTestDetalleProducto.TabIndex = 29;
            this.btnTestDetalleProducto.Text = ">>";
            this.btnTestDetalleProducto.UseVisualStyleBackColor = true;
            this.btnTestDetalleProducto.Click += new System.EventHandler(this.btnTestDetalleProducto_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 691);
            this.Controls.Add(this.btnTestDetalleProducto);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.lblCantidadProductosEnCarro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCarro);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1160, 730);
            this.MinimumSize = new System.Drawing.Size(1160, 730);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercado Cliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBuscarProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.PictureBox pbCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBuscarProductos;
        private System.Windows.Forms.ComboBox comboOrdenarProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrdenarProductos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidadProductosEnCarro;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtBuscarProductos;
        private System.Windows.Forms.Button btnTestDetalleProducto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}