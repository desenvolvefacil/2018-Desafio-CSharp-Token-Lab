using _2018_Desafio_CSharp_Token_Lab.Model;
using _2018_Desafio_CSharp_Token_Lab.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_Desafio_CSharp_Token_Lab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //cria o evento para quando a aplicação for fechada
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();



            if (Util.UsuarioLogado != null)
            {
                Application.Run(new EventosForm());

            }

        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            //Fecha a conexão com o banco de dados
            Util.DB.Dispose();
        }
    }
}
