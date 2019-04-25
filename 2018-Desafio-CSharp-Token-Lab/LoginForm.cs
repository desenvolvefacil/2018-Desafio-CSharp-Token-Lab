using _2018_Desafio_CSharp_Token_Lab.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_Desafio_CSharp_Token_Lab
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();



        }

        private void CadastrarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Desejsa Cadastrar?","Cadastro",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                UsuarioEntity entity = new UsuarioEntity() { Login = LoginTextBox.Text, Senha = SenhaTextBox.Text };

                if (UsuarioModel.Salvar(entity))
                {
                    MessageBox.Show("Usuario Cadastrado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Usuario");
                }
            }
        }

        private void EntarButton_Click(object sender, EventArgs e)
        {
            Utils.Util.UsuarioLogado = UsuarioModel.Logar(LoginTextBox.Text, SenhaTextBox.Text);

            if (Utils.Util.UsuarioLogado != null)
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Invalido");
            }
        }
    }
}
