using System;
using System.Windows.Forms;

namespace PrinterQueue
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Simple s = new Simple();
            s.Run();
            Application.Run(new Form1());
        }
    }
}
