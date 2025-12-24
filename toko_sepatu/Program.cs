using System;
using System.Windows.Forms;
using toko_sepatu.View; 
namespace toko_sepatu
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Loading());
        }
    }
}