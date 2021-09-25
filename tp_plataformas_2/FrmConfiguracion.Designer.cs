
namespace tp_plataformas_2
{
    partial class FrmConfiguracion
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
            System.Windows.Forms.Button btnExplorar;
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardarRuta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardarRutaDestino = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cargandoMain = new System.Windows.Forms.ProgressBar();
            btnExplorar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExplorar
            // 
            btnExplorar.Location = new System.Drawing.Point(421, 148);
            btnExplorar.Name = "btnExplorar";
            btnExplorar.Size = new System.Drawing.Size(46, 23);
            btnExplorar.TabIndex = 9;
            btnExplorar.Text = "...";
            btnExplorar.UseVisualStyleBackColor = true;
            btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(10, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(453, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configurando almacenamiento de archivos...";
            // 
            // btnGuardarRuta
            // 
            this.btnGuardarRuta.Location = new System.Drawing.Point(400, 27);
            this.btnGuardarRuta.Name = "btnGuardarRuta";
            this.btnGuardarRuta.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRuta.TabIndex = 2;
            this.btnGuardarRuta.Text = "TestConfirm";
            this.btnGuardarRuta.UseVisualStyleBackColor = true;
            this.btnGuardarRuta.Click += new System.EventHandler(this.btnConfirmar);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu,
            this.mnuAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(50, 20);
            this.mnuMenu.Text = "Menu";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(71, 20);
            this.mnuAcercaDe.Text = "Acerca de";
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDirectorio.Location = new System.Drawing.Point(21, 146);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(88, 21);
            this.lblDirectorio.TabIndex = 6;
            this.lblDirectorio.Text = "Directorio:";
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(115, 148);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(300, 23);
            this.txtDirectorio.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardarRutaDestino
            // 
            this.btnGuardarRutaDestino.Location = new System.Drawing.Point(21, 186);
            this.btnGuardarRutaDestino.Name = "btnGuardarRutaDestino";
            this.btnGuardarRutaDestino.Size = new System.Drawing.Size(153, 23);
            this.btnGuardarRutaDestino.TabIndex = 10;
            this.btnGuardarRutaDestino.Text = "Confirmar ruta de destino";
            this.btnGuardarRutaDestino.UseVisualStyleBackColor = true;
            this.btnGuardarRutaDestino.Click += new System.EventHandler(this.btnGuardarRutaDestino_Click);
            // 
            // cargandoMain
            // 
            this.cargandoMain.Location = new System.Drawing.Point(0, 225);
            this.cargandoMain.Name = "cargandoMain";
            this.cargandoMain.Size = new System.Drawing.Size(475, 23);
            this.cargandoMain.TabIndex = 21;
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 244);
            this.Controls.Add(this.cargandoMain);
            this.Controls.Add(this.btnGuardarRutaDestino);
            this.Controls.Add(btnExplorar);
            this.Controls.Add(this.txtDirectorio);
            this.Controls.Add(this.lblDirectorio);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGuardarRuta);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacenamiento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private System.Windows.Forms.Label lblDirectorio;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.RichTextBox rtxtContenido;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuardarRuta;
        private System.Windows.Forms.Button btnGuardarRutaDestino;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar cargandoMain;
    }
}