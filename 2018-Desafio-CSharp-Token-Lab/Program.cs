using _2018_Desafio_CSharp_Token_Lab.Model;
using _2018_Desafio_CSharp_Token_Lab.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://docs.microsoft.com/pt-br/ef/ef6/querying/
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

            //chama a tela de login
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();


            //caso tenha logado corretamente chama a tela de eventos
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
