
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.btnGuardarRuta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardarRutaDestino = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cargandoMain = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            btnExplorar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExplorar
            // 
            btnExplorar.Location = new System.Drawing.Point(326, 169);
            btnExplorar.Name = "btnExplorar";
            btnExplorar.Size = new System.Drawing.Size(46, 23);
            btnExplorar.TabIndex = 9;
            btnExplorar.Text = "...";
            btnExplorar.UseVisualStyleBackColor = true;
            btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // btnGuardarRuta
            // 
            this.btnGuardarRuta.Location = new System.Drawing.Point(10, 259);
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
            this.volverToolStripMenuItem});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(60, 20);
            this.mnuMenu.Text = "Archivo";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
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
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDirectorio.Location = new System.Drawing.Point(10, 167);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(88, 21);
            this.lblDirectorio.TabIndex = 6;
            this.lblDirectorio.Text = "Directorio:";
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(104, 169);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(216, 23);
            this.txtDirectorio.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardarRutaDestino
            // 
            this.btnGuardarRutaDestino.Location = new System.Drawing.Point(10, 207);
            this.btnGuardarRutaDestino.Name = "btnGuardarRutaDestino";
            this.btnGuardarRutaDestino.Size = new System.Drawing.Size(153, 23);
            this.btnGuardarRutaDestino.TabIndex = 10;
            this.btnGuardarRutaDestino.Text = "Confirmar ruta de destino";
            this.btnGuardarRutaDestino.UseVisualStyleBackColor = true;
            this.btnGuardarRutaDestino.Click += new System.EventHandler(this.btnGuardarRutaDestino_Click);
            // 
            // cargandoMain
            // 
            this.cargandoMain.Location = new System.Drawing.Point(0, 441);
            this.cargandoMain.Name = "cargandoMain";
            this.cargandoMain.Size = new System.Drawing.Size(384, 23);
            this.cargandoMain.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 101);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(318, 30);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Configurando almacenamiento";
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cargandoMain);
            this.Controls.Add(this.btnGuardarRutaDestino);
            this.Controls.Add(btnExplorar);
            this.Controls.Add(this.txtDirectorio);
            this.Controls.Add(this.lblDirectorio);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGuardarRuta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacenamiento";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.Label lblDirectorio;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.RichTextBox rtxtContenido;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuardarRuta;
        private System.Windows.Forms.Button btnGuardarRutaDestino;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar cargandoMain;
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
        private System.Windows.Forms.Label lblTitulo;
    }
}