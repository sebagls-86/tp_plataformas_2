﻿
namespace tp_plataformas_2
{
    partial class FrmRegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarUsuario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.cargandoMain = new System.Windows.Forms.ProgressBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            this.pictureUsuarios = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(50, 20);
            this.mnuMenu.Text = "Menu";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuSalir.Text = "Volver";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 23);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(180, 145);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 23);
            this.txtApellido.TabIndex = 13;
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(180, 189);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(167, 23);
            this.txtCuil.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(180, 278);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(167, 23);
            this.txtPassword.TabIndex = 16;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(180, 231);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(167, 23);
            this.txtMail.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(33, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 28);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Ingrese sus datos";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearUsuario.Location = new System.Drawing.Point(69, 411);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(85, 29);
            this.btnCrearUsuario.TabIndex = 19;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // cargandoMain
            // 
            this.cargandoMain.Location = new System.Drawing.Point(0, 628);
            this.cargandoMain.Name = "cargandoMain";
            this.cargandoMain.Size = new System.Drawing.Size(460, 23);
            this.cargandoMain.TabIndex = 20;
            this.cargandoMain.Click += new System.EventHandler(this.cargandoMain_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(69, 361);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 19);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "No es Empresa";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(69, 332);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 19);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Es Empresa";
            this.radioButton2.UseVisualStyleBackColor = true;
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
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
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
            // pictureUsuarios
            // 
            this.pictureUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pictureUsuarios.Image")));
            this.pictureUsuarios.Location = new System.Drawing.Point(406, 31);
            this.pictureUsuarios.Name = "pictureUsuarios";
            this.pictureUsuarios.Size = new System.Drawing.Size(42, 36);
            this.pictureUsuarios.TabIndex = 34;
            this.pictureUsuarios.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Contraseña";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(67, 197);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 15);
            this.label22.TabIndex = 41;
            this.label22.Text = "CUIL/CUT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "Mail";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureUsuarios);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cargandoMain);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "FrmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.FrmRegistrarUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.ProgressBar cargandoMain;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
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
        private System.Windows.Forms.PictureBox pictureUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}