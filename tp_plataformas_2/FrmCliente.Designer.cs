
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.callejaHoracioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cohenNicolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kimAnastaciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kukutchkaMarcosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopezEmmanuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopezSosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motzoFrancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Prod_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbCarro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBuscarProductos = new System.Windows.Forms.PictureBox();
            this.comboOrdenarProductos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrdenarProductos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarProductos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidadProductosEnCarro = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Id_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1623, 35);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(88, 29);
            this.mnuMenu.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            this.cerrarSesionToolStripMenuItem.Text = "Volver";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(105, 29);
            this.toolStripMenuItem1.Text = "Acerca de";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 34);
            this.toolStripMenuItem3.Text = "Materia";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callejaHoracioToolStripMenuItem,
            this.cohenNicolasToolStripMenuItem,
            this.kimAnastaciaToolStripMenuItem,
            this.kukutchkaMarcosToolStripMenuItem,
            this.lopezEmmanuelToolStripMenuItem,
            this.lopezSosaToolStripMenuItem,
            this.motzoFrancoToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 34);
            this.toolStripMenuItem2.Text = "Integrantes";
            // 
            // callejaHoracioToolStripMenuItem
            // 
            this.callejaHoracioToolStripMenuItem.Name = "callejaHoracioToolStripMenuItem";
            this.callejaHoracioToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.callejaHoracioToolStripMenuItem.Text = "Calleja Horacio";
            // 
            // cohenNicolasToolStripMenuItem
            // 
            this.cohenNicolasToolStripMenuItem.Name = "cohenNicolasToolStripMenuItem";
            this.cohenNicolasToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.cohenNicolasToolStripMenuItem.Text = "Cohen Nicolas";
            // 
            // kimAnastaciaToolStripMenuItem
            // 
            this.kimAnastaciaToolStripMenuItem.Name = "kimAnastaciaToolStripMenuItem";
            this.kimAnastaciaToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.kimAnastaciaToolStripMenuItem.Text = "Kim Anastasia";
            // 
            // kukutchkaMarcosToolStripMenuItem
            // 
            this.kukutchkaMarcosToolStripMenuItem.Name = "kukutchkaMarcosToolStripMenuItem";
            this.kukutchkaMarcosToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.kukutchkaMarcosToolStripMenuItem.Text = "Kukutchka Marcos";
            // 
            // lopezEmmanuelToolStripMenuItem
            // 
            this.lopezEmmanuelToolStripMenuItem.Name = "lopezEmmanuelToolStripMenuItem";
            this.lopezEmmanuelToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.lopezEmmanuelToolStripMenuItem.Text = "Lopez Emmanuel";
            // 
            // lopezSosaToolStripMenuItem
            // 
            this.lopezSosaToolStripMenuItem.Name = "lopezSosaToolStripMenuItem";
            this.lopezSosaToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.lopezSosaToolStripMenuItem.Text = "Lopez Sosa Sebastian";
            // 
            // motzoFrancoToolStripMenuItem
            // 
            this.motzoFrancoToolStripMenuItem.Name = "motzoFrancoToolStripMenuItem";
            this.motzoFrancoToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.motzoFrancoToolStripMenuItem.Text = "Motzo Franco";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prod_Id,
            this.nombre_producto,
            this.precioProd,
            this.cantProducto,
            this.catProducto});
            this.dgvProductos.Location = new System.Drawing.Point(640, 547);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(774, 488);
            this.dgvProductos.TabIndex = 13;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // Prod_Id
            // 
            this.Prod_Id.HeaderText = "Id de Producto";
            this.Prod_Id.MinimumWidth = 8;
            this.Prod_Id.Name = "Prod_Id";
            this.Prod_Id.Width = 150;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Nombre";
            this.nombre_producto.MinimumWidth = 8;
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.Width = 150;
            // 
            // precioProd
            // 
            this.precioProd.HeaderText = "Precio";
            this.precioProd.MinimumWidth = 8;
            this.precioProd.Name = "precioProd";
            this.precioProd.Width = 150;
            // 
            // cantProducto
            // 
            this.cantProducto.HeaderText = "Cantidad Disponible";
            this.cantProducto.MinimumWidth = 8;
            this.cantProducto.Name = "cantProducto";
            this.cantProducto.Width = 150;
            // 
            // catProducto
            // 
            this.catProducto.HeaderText = "Categoria";
            this.catProducto.MinimumWidth = 8;
            this.catProducto.Name = "catProducto";
            this.catProducto.Width = 150;
            // 
            // pbCarro
            // 
            this.pbCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCarro.Image = ((System.Drawing.Image)(resources.GetObject("pbCarro.Image")));
            this.pbCarro.Location = new System.Drawing.Point(1519, 77);
            this.pbCarro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbCarro.Name = "pbCarro";
            this.pbCarro.Size = new System.Drawing.Size(57, 67);
            this.pbCarro.TabIndex = 15;
            this.pbCarro.TabStop = false;
            this.pbCarro.Click += new System.EventHandler(this.pbCarro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(531, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "¡Bienvenido a nuestro Mercado!";
            // 
            // pictureBuscarProductos
            // 
            this.pictureBuscarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBuscarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBuscarProductos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBuscarProductos.Image")));
            this.pictureBuscarProductos.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBuscarProductos.InitialImage")));
            this.pictureBuscarProductos.Location = new System.Drawing.Point(113, 137);
            this.pictureBuscarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBuscarProductos.Name = "pictureBuscarProductos";
            this.pictureBuscarProductos.Size = new System.Drawing.Size(44, 48);
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
            this.comboOrdenarProductos.Location = new System.Drawing.Point(9, 47);
            this.comboOrdenarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboOrdenarProductos.Name = "comboOrdenarProductos";
            this.comboOrdenarProductos.Size = new System.Drawing.Size(267, 40);
            this.comboOrdenarProductos.TabIndex = 21;
            this.comboOrdenarProductos.SelectedIndexChanged += new System.EventHandler(this.comboOrdenarProductos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrdenarProductos);
            this.groupBox1.Controls.Add(this.comboOrdenarProductos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(1129, 307);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(286, 208);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar por";
            // 
            // btnOrdenarProductos
            // 
            this.btnOrdenarProductos.Location = new System.Drawing.Point(53, 132);
            this.btnOrdenarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrdenarProductos.Name = "btnOrdenarProductos";
            this.btnOrdenarProductos.Size = new System.Drawing.Size(159, 53);
            this.btnOrdenarProductos.TabIndex = 22;
            this.btnOrdenarProductos.Text = "Aplicar";
            this.btnOrdenarProductos.UseVisualStyleBackColor = true;
            this.btnOrdenarProductos.Click += new System.EventHandler(this.btnOrdenarProductos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarProductos);
            this.groupBox2.Controls.Add(this.pictureBuscarProductos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(640, 307);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(286, 208);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por nombre";
            // 
            // txtBuscarProductos
            // 
            this.txtBuscarProductos.Location = new System.Drawing.Point(9, 47);
            this.txtBuscarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.Size = new System.Drawing.Size(267, 39);
            this.txtBuscarProductos.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(180, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Categorias";
            // 
            // lblCantidadProductosEnCarro
            // 
            this.lblCantidadProductosEnCarro.AutoSize = true;
            this.lblCantidadProductosEnCarro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadProductosEnCarro.Location = new System.Drawing.Point(1577, 55);
            this.lblCantidadProductosEnCarro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadProductosEnCarro.Name = "lblCantidadProductosEnCarro";
            this.lblCantidadProductosEnCarro.Size = new System.Drawing.Size(27, 32);
            this.lblCantidadProductosEnCarro.TabIndex = 27;
            this.lblCantidadProductosEnCarro.Text = "0";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Categoria,
            this.Nombre_Categoria});
            this.dgvCategorias.Location = new System.Drawing.Point(180, 378);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 62;
            this.dgvCategorias.RowTemplate.Height = 25;
            this.dgvCategorias.Size = new System.Drawing.Size(349, 635);
            this.dgvCategorias.TabIndex = 28;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            this.dgvCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellDoubleClick);
            this.dgvCategorias.DoubleClick += new System.EventHandler(this.dgvCategorias_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Id_Categoria
            // 
            this.Id_Categoria.HeaderText = "Codigo de Categoria";
            this.Id_Categoria.MinimumWidth = 8;
            this.Id_Categoria.Name = "Id_Categoria";
            this.Id_Categoria.ReadOnly = true;
            this.Id_Categoria.Width = 150;
            // 
            // Nombre_Categoria
            // 
            this.Nombre_Categoria.HeaderText = "Nombre";
            this.Nombre_Categoria.MinimumWidth = 8;
            this.Nombre_Categoria.Name = "Nombre_Categoria";
            this.Nombre_Categoria.ReadOnly = true;
            this.Nombre_Categoria.Width = 150;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1623, 1112);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.lblCantidadProductosEnCarro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCarro);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1645, 1168);
            this.MinimumSize = new System.Drawing.Size(1645, 1006);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercado Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
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
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.PictureBox pbCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBuscarProductos;
        private System.Windows.Forms.ComboBox comboOrdenarProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrdenarProductos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidadProductosEnCarro;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox txtBuscarProductos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem callejaHoracioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cohenNicolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kimAnastaciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kukutchkaMarcosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopezEmmanuelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopezSosaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motzoFrancoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn catProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Categoria;
    }
}