using System;
using System.Windows.Forms;

namespace tp_plataformas_2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

            Mercado mercado = new Mercado();


        }
    }
}
