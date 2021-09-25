using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Librerias para trabajar con archivos

namespace tp_plataformas_2
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void btnConfirmar(object sender, EventArgs e)
        {
            TextWriter Entrada = new StreamWriter("almacenamiento.txt");
            Entrada.WriteLine("Test creacion de archivo");
            Entrada.Close();

            MessageBox.Show("Ruta guardada");
            Entrada.Close();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain VtnaMain = new FrmMain();
            VtnaMain.Show();
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Selecionar ruta de guardado";
            folderDialog.RootFolder = Environment.SpecialFolder.MyDocuments;

            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDirectorio.Text = folderDialog.SelectedPath;
            }
        }

        private void btnGuardarRutaDestino_Click(object sender, EventArgs e)
        {
            cargandoMain.Minimum = 1;
            cargandoMain.Maximum = 100;
            cargandoMain.Step = 1;

            for (int i = 0; i < 100; i++)
            {
                cargandoMain.PerformStep();
            }

            string rutaDirectorio = txtDirectorio.Text;
            MessageBox.Show("Ruta seleccionada: \n" + rutaDirectorio + "\n¡Guardada con exito!");
        }
    }
}
