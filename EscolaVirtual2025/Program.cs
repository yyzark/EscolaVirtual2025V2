using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace EscolaVirtual2025
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //Declaração do objeto global do form de login
        public static Form_Login formLogin;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Lingua em português
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-PT");

            //objeto global do form de login
            formLogin = new Form_Login();

            Application.Run(formLogin);
        }
    }
}
