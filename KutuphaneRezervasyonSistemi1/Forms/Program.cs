using System;
using System.Windows.Forms;
using KutuphaneRezervasyonSistemi1.Forms;

namespace KutuphaneRezervasyonSistemi1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}