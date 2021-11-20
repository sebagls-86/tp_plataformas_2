
namespace tp_plataformas_2
{
    partial class FrmDetalleProducto
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
            Mercado.cerrar();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleProducto));
            this.btnAgregarAlCarro = new System.Windows.Forms.Button();
            this.groupDetallesProducto = new System.Windows.Forms.GroupBox();
            this.txtCantidadComprar = new System.Windows.Forms.TextBox();
            this.lblSelecccionarCantidad = new System.Windows.Forms.Label();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblProductoNombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupDetallesProducto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarAlCarro
            // 
            this.btnAgregarAlCarro.Location = new System.Drawing.Point(16, 248);
            this.btnAgregarAlCarro.Name = "btnAgregarAlCarro";
            this.btnAgregarAlCarro.Size = new System.Drawing.Size(140, 34);
            this.btnAgregarAlCarro.TabIndex = 0;
            this.btnAgregarAlCarro.Text = "Agregar al Carro";
            this.btnAgregarAlCarro.UseVisualStyleBackColor = true;
            this.btnAgregarAlCarro.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupDetallesProducto
            // 
            this.groupDetallesProducto.Controls.Add(this.txtCantidadComprar);
            this.groupDetallesProducto.Controls.Add(this.btnAgregarAlCarro);
            this.groupDetallesProducto.Controls.Add(this.lblSelecccionarCantidad);
            this.groupDetallesProducto.Controls.Add(this.lblCategoriaProducto);
            this.groupDetallesProducto.Controls.Add(this.lblPrecioProducto);
            this.groupDetallesProducto.Controls.Add(this.lblProductoNombre);
            this.groupDetallesProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupDetallesProducto.Location = new System.Drawing.Point(358, 248);
            this.groupDetallesProducto.Name = "groupDetallesProducto";
            this.groupDetallesProducto.Size = new System.Drawing.Size(298, 321);
            this.groupDetallesProducto.TabIndex = 24;
            this.groupDetallesProducto.TabStop = false;
            this.groupDetallesProducto.Text = "Detalles de producto";
            // 
            // txtCantidadComprar
            // 
            this.txtCantidadComprar.Location = new System.Drawing.Point(192, 167);
            this.txtCantidadComprar.Name = "txtCantidadComprar";
            this.txtCantidadComprar.Size = new System.Drawing.Size(100, 29);
            this.txtCantidadComprar.TabIndex = 27;
            // 
            // lblSelecccionarCantidad
            // 
            this.lblSelecccionarCantidad.AutoSize = true;
            this.lblSelecccionarCantidad.Location = new System.Drawing.Point(7, 170);
            this.lblSelecccionarCantidad.Name = "lblSelecccionarCantidad";
            this.lblSelecccionarCantidad.Size = new System.Drawing.Size(139, 21);
            this.lblSelecccionarCantidad.TabIndex = 26;
            this.lblSelecccionarCantidad.Text = "Ingresar Cantidad";
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Location = new System.Drawing.Point(7, 124);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(84, 21);
            this.lblCategoriaProducto.TabIndex = 25;
            this.lblCategoriaProducto.Text = "Alimentos";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(7, 85);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(68, 21);
            this.lblPrecioProducto.TabIndex = 1;
            this.lblPrecioProducto.Text = "ARS 120";
            // 
            // lblProductoNombre
            // 
            this.lblProductoNombre.AutoSize = true;
            this.lblProductoNombre.Location = new System.Drawing.Point(6, 48);
            this.lblProductoNombre.Name = "lblProductoNombre";
            this.lblProductoNombre.Size = new System.Drawing.Size(50, 21);
            this.lblProductoNombre.TabIndex = 0;
            this.lblProductoNombre.Text = "Arroz";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Acerca de";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem2.Text = "Integrantes";
            // 
            // callejaHoracioToolStripMenuItem
            // 
            this.callejaHoracioToolStripMenuItem.Name = "callejaHoracioToolStripMenuItem";
            this.callejaHoracioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.callejaHoracioToolStripMenuItem.Text = "Calleja Horacio";
            // 
            // cohenNicolasToolStripMenuItem
            // 
            this.cohenNicolasToolStripMenuItem.Name = "cohenNicolasToolStripMenuItem";
            this.cohenNicolasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cohenNicolasToolStripMenuItem.Text = "Cohen Nicolas";
            // 
            // kimAnastaciaToolStripMenuItem
            // 
            this.kimAnastaciaToolStripMenuItem.Name = "kimAnastaciaToolStripMenuItem";
            this.kimAnastaciaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kimAnastaciaToolStripMenuItem.Text = "Kim Anastasia";
            // 
            // kukutchkaMarcosToolStripMenuItem
            // 
            this.kukutchkaMarcosToolStripMenuItem.Name = "kukutchkaMarcosToolStripMenuItem";
            this.kukutchkaMarcosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kukutchkaMarcosToolStripMenuItem.Text = "Kukutchka Marcos";
            // 
            // lopezEmmanuelToolStripMenuItem
            // 
            this.lopezEmmanuelToolStripMenuItem.Name = "lopezEmmanuelToolStripMenuItem";
            this.lopezEmmanuelToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.lopezEmmanuelToolStripMenuItem.Text = "Lopez Emmanuel";
            // 
            // lopezSosaToolStripMenuItem
            // 
            this.lopezSosaToolStripMenuItem.Name = "lopezSosaToolStripMenuItem";
            this.lopezSosaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.lopezSosaToolStripMenuItem.Text = "Lopez Sosa Sebastian";
            // 
            // motzoFrancoToolStripMenuItem
            // 
            this.motzoFrancoToolStripMenuItem.Name = "motzoFrancoToolStripMenuItem";
            this.motzoFrancoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.motzoFrancoToolStripMenuItem.Text = "Motzo Franco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(358, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Agregando productos al Carro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(782, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 112);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 691);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupDetallesProducto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1160, 730);
            this.MinimumSize = new System.Drawing.Size(1160, 730);
            this.Name = "FrmDetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Producto";
            this.groupDetallesProducto.ResumeLayout(false);
            this.groupDetallesProducto.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAlCarro;
        private System.Windows.Forms.GroupBox groupDetallesProducto;
        private System.Windows.Forms.Label lblProductoNombre;
        private System.Windows.Forms.Label lblSelecccionarCantidad;
        private System.Windows.Forms.Label lblCategoriaProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.TextBox txtCantidadComprar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}