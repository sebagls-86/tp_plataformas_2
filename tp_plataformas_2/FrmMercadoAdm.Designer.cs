﻿
namespace tp_plataformas_2
{
    partial class FrmMercadoAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMercadoAdm));
            this.panelCategorias = new System.Windows.Forms.Panel();
            this.panelAgregarCategoria = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtboxNombreCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMuestraCategoria = new System.Windows.Forms.Panel();
            this.dataTableCategorias = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.lblTitleCompras = new System.Windows.Forms.Label();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.lblTitleUsuarios = new System.Windows.Forms.Label();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.lblTitleProductos = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCategorias.SuspendLayout();
            this.panelAgregarCategoria.SuspendLayout();
            this.panelMuestraCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCategorias)).BeginInit();
            this.panelCompras.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCategorias
            // 
            this.panelCategorias.Controls.Add(this.panelAgregarCategoria);
            this.panelCategorias.Controls.Add(this.panelMuestraCategoria);
            this.panelCategorias.Controls.Add(this.button3);
            this.panelCategorias.Controls.Add(this.button2);
            this.panelCategorias.Controls.Add(this.btnAgregarCategoria);
            this.panelCategorias.Location = new System.Drawing.Point(181, 65);
            this.panelCategorias.MinimumSize = new System.Drawing.Size(1076, 596);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.Size = new System.Drawing.Size(1083, 596);
            this.panelCategorias.TabIndex = 0;
            this.panelCategorias.Visible = false;
            // 
            // panelAgregarCategoria
            // 
            this.panelAgregarCategoria.Controls.Add(this.btnAgregar);
            this.panelAgregarCategoria.Controls.Add(this.txtboxNombreCategoria);
            this.panelAgregarCategoria.Controls.Add(this.label1);
            this.panelAgregarCategoria.Location = new System.Drawing.Point(3, 112);
            this.panelAgregarCategoria.Name = "panelAgregarCategoria";
            this.panelAgregarCategoria.Size = new System.Drawing.Size(1083, 481);
            this.panelAgregarCategoria.TabIndex = 8;
            this.panelAgregarCategoria.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(509, 228);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtboxNombreCategoria
            // 
            this.txtboxNombreCategoria.Location = new System.Drawing.Point(255, 120);
            this.txtboxNombreCategoria.Name = "txtboxNombreCategoria";
            this.txtboxNombreCategoria.Size = new System.Drawing.Size(335, 23);
            this.txtboxNombreCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar categoria panel";
            // 
            // panelMuestraCategoria
            // 
            this.panelMuestraCategoria.Controls.Add(this.dataTableCategorias);
            this.panelMuestraCategoria.Location = new System.Drawing.Point(3, 112);
            this.panelMuestraCategoria.Name = "panelMuestraCategoria";
            this.panelMuestraCategoria.Size = new System.Drawing.Size(1083, 497);
            this.panelMuestraCategoria.TabIndex = 7;
            this.panelMuestraCategoria.Visible = false;
            // 
            // dataTableCategorias
            // 
            this.dataTableCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableCategorias.Location = new System.Drawing.Point(199, 105);
            this.dataTableCategorias.Name = "dataTableCategorias";
            this.dataTableCategorias.RowTemplate.Height = 25;
            this.dataTableCategorias.Size = new System.Drawing.Size(535, 306);
            this.dataTableCategorias.TabIndex = 6;
            this.dataTableCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableCategorias_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCategoria.Image")));
            this.btnAgregarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(157, 27);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(106, 49);
            this.btnAgregarCategoria.TabIndex = 3;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // panelCompras
            // 
            this.panelCompras.Controls.Add(this.lblTitleCompras);
            this.panelCompras.Controls.Add(this.panelUsuarios);
            this.panelCompras.Location = new System.Drawing.Point(54, 672);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(1102, 621);
            this.panelCompras.TabIndex = 2;
            this.panelCompras.Visible = false;
            // 
            // lblTitleCompras
            // 
            this.lblTitleCompras.AutoSize = true;
            this.lblTitleCompras.Location = new System.Drawing.Point(30, 18);
            this.lblTitleCompras.Name = "lblTitleCompras";
            this.lblTitleCompras.Size = new System.Drawing.Size(55, 15);
            this.lblTitleCompras.TabIndex = 1;
            this.lblTitleCompras.Text = "Compras";
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Controls.Add(this.lblTitleUsuarios);
            this.panelUsuarios.Controls.Add(this.panelProductos);
            this.panelUsuarios.Location = new System.Drawing.Point(3, 488);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(1102, 621);
            this.panelUsuarios.TabIndex = 3;
            this.panelUsuarios.Visible = false;
            // 
            // lblTitleUsuarios
            // 
            this.lblTitleUsuarios.AutoSize = true;
            this.lblTitleUsuarios.Location = new System.Drawing.Point(30, 18);
            this.lblTitleUsuarios.Name = "lblTitleUsuarios";
            this.lblTitleUsuarios.Size = new System.Drawing.Size(52, 15);
            this.lblTitleUsuarios.TabIndex = 1;
            this.lblTitleUsuarios.Text = "Usuarios";
            // 
            // panelProductos
            // 
            this.panelProductos.Controls.Add(this.lblTitleProductos);
            this.panelProductos.Location = new System.Drawing.Point(18, 313);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(1102, 621);
            this.panelProductos.TabIndex = 1;
            this.panelProductos.Visible = false;
            // 
            // lblTitleProductos
            // 
            this.lblTitleProductos.AutoSize = true;
            this.lblTitleProductos.Location = new System.Drawing.Point(30, 18);
            this.lblTitleProductos.Name = "lblTitleProductos";
            this.lblTitleProductos.Size = new System.Drawing.Size(61, 15);
            this.lblTitleProductos.TabIndex = 1;
            this.lblTitleProductos.Text = "Productos";
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(12, 303);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(141, 94);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(12, 194);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(141, 94);
            this.btnCategorias.TabIndex = 0;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
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
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem3.Text = "Materia";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Plataformas de Desarrollo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem2.Text = "Integrantes";
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(12, 416);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(141, 94);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(12, 526);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(141, 94);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(1211, 27);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(41, 32);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainTitle.Location = new System.Drawing.Point(181, 24);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(54, 30);
            this.lblMainTitle.TabIndex = 5;
            this.lblMainTitle.Text = "Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1105, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMercadoAdm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.panelCompras);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.panelCategorias);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercado - Administrador";
            this.Load += new System.EventHandler(this.FrmMercadoAdmin_Load);
            this.panelCategorias.ResumeLayout(false);
            this.panelAgregarCategoria.ResumeLayout(false);
            this.panelAgregarCategoria.PerformLayout();
            this.panelMuestraCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCategorias)).EndInit();
            this.panelCompras.ResumeLayout(false);
            this.panelCompras.PerformLayout();
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.panelProductos.ResumeLayout(false);
            this.panelProductos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCategorias;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Label lblTitleProductos;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Label lblTitleCompras;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Label lblTitleUsuarios;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dataTableCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.Panel panelMuestraCategoria;
        private System.Windows.Forms.Panel panelAgregarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtboxNombreCategoria;
        private System.Windows.Forms.Button button1;
    }
}