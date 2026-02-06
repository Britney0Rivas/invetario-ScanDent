using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var login = new Form1())
            {
                Application.Run(login);

                if (!login.LoginOk) return;
            }

            Application.Run(new Form2());
        }
    }
}
