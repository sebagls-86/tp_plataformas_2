
namespace tp_plataformas_2
{
    partial class FrmAdministracion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVolver = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.cboAdministracion = new System.Windows.Forms.ComboBox();
            this.cargandoMain = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu,
            this.mnuAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 2;
            // 
            // mnuMenu
            // 
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVolver});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(50, 20);
            this.mnuMenu.Text = "Menu";
            this.mnuMenu.Click += new System.EventHandler(this.mnuMenu_Click);
            // 
            // mnuVolver
            // 
            this.mnuVolver.Name = "mnuVolver";
            this.mnuVolver.Size = new System.Drawing.Size(106, 22);
            this.mnuVolver.Text = "Volver";
            this.mnuVolver.Click += new System.EventHandler(this.mnuVolver_Click);
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(71, 20);
            this.mnuAcercaDe.Text = "Acerca de";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(12, 91);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // cboAdministracion
            // 
            this.cboAdministracion.FormattingEnabled = true;
            this.cboAdministracion.Items.AddRange(new object[] {
            "Alta de categoría",
            "Baja de categoría",
            "Modificación de categoría",
            "Mostrar categorías que existen en el sistema",
            "Alta de usuario",
            "Baja de usuario",
            "Modificación de usuario",
            "Mostrar usuarios que existen en el sistema",
            "Alta de producto",
            "Baja de producto",
            "Modificación de producto",
            "Mostrar productos que existen en el sistema",
            "Mostrar productos que existen en el sistema ordenados por precio",
            "Mostrar productos que existen en el sistema ordenados por categoría"});
            this.cboAdministracion.Location = new System.Drawing.Point(12, 49);
            this.cboAdministracion.Name = "cboAdministracion";
            this.cboAdministracion.Size = new System.Drawing.Size(378, 23);
            this.cboAdministracion.TabIndex = 4;
            this.cboAdministracion.Text = "Seleccione una opcion";
            // 
            // cargandoMain
            // 
            this.cargandoMain.Location = new System.Drawing.Point(0, 132);
            this.cargandoMain.Name = "cargandoMain";
            this.cargandoMain.Size = new System.Drawing.Size(429, 23);
            this.cargandoMain.TabIndex = 21;
            // 
            // FrmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 155);
            this.Controls.Add(this.cargandoMain);
            this.Controls.Add(this.cboAdministracion);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuVolver;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.ComboBox cboAdministracion;
        private System.Windows.Forms.ProgressBar cargandoMain;
    }
}