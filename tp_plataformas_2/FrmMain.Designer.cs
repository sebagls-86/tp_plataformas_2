
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.cargandoMain = new System.Windows.Forms.ProgressBar();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(63, 69);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 37);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Ingreso de Usuarios";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu,
            this.mnuAcercaDe});
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
            this.mnuSalir.Size = new System.Drawing.Size(96, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(71, 20);
            this.mnuAcercaDe.Text = "Acerca de";
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
            this.txtUsuario.Location = new System.Drawing.Point(121, 137);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(131, 23);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(121, 178);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(131, 23);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(121, 221);
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
            this.lblRegistrarse.Location = new System.Drawing.Point(20, 342);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(287, 21);
            this.lblRegistrarse.TabIndex = 10;
            this.lblRegistrarse.Text = "No tengo usuario y deseo registrarme";
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(84, 265);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(209, 23);
            this.btnConfiguracion.TabIndex = 11;
            this.btnConfiguracion.Text = "Configurar almacenamiento";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(20, 385);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(116, 23);
            this.btnRegistrarse.TabIndex = 12;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.lblRegistrarse);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cargandoMain);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private System.Windows.Forms.ProgressBar cargandoMain;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}

