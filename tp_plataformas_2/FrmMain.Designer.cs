
namespace tp_plataformas_2
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.cargandoMain = new System.Windows.Forms.ProgressBar();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 4;
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
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // cargandoMain
            // 
            this.cargandoMain.Location = new System.Drawing.Point(-2, 425);
            this.cargandoMain.Name = "cargandoMain";
            this.cargandoMain.Size = new System.Drawing.Size(384, 23);
            this.cargandoMain.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(125, 177);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(131, 23);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 218);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(131, 23);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(125, 261);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(131, 23);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistrarse.Location = new System.Drawing.Point(20, 363);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(287, 21);
            this.lblRegistrarse.TabIndex = 10;
            this.lblRegistrarse.Text = "No tengo usuario y deseo registrarme";
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(88, 305);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(209, 23);
            this.btnConfiguracion.TabIndex = 11;
            this.btnConfiguracion.Text = "Configurar almacenamiento";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(20, 387);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(116, 23);
            this.btnRegistrarse.TabIndex = 12;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 103);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.lblRegistrarse);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cargandoMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ProgressBar cargandoMain;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnRegistrarse;
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

