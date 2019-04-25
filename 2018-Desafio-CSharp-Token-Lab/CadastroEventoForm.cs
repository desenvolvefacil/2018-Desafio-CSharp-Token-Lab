using _2018_Desafio_CSharp_Token_Lab.Enum;
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
    public partial class CadastroEventoForm : Form
    {
        public StatusEnum Status = StatusEnum.PADRAO;
        EventoEntity entity;

        public CadastroEventoForm(EventoEntity entity)
        {
            InitializeComponent();

            this.entity = entity;

            DataTextBox.Text = entity.Data.ToShortDateString();

            if (entity.Id > 0)
            {
                //restaura os valores em tela
                InicioMaskedTextBox.Text = entity.Inicio.ToString(@"\.hh\:mm");
                FimMaskedTextBox.Text = entity.Fim.ToString(@"\.hh\:mm");
                DescricaoTextBox.Text = entity.Descricao;

                //habilita o botao excluir
                ExcluirLinkLabel.Visible = true;
            }



        }

        private void CadastrarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool erro = false;
            try
            {
                String[] horaEvento = InicioMaskedTextBox.Text.Split(':');
                int horas = int.Parse(horaEvento[0]);
                int minutos = int.Parse(horaEvento[1]);
                int segundos = 0;
                entity.Inicio = new TimeSpan(horas, minutos, segundos);
            }
            catch
            {
                MessageBox.Show("Erro na Hora de inicio");
                InicioMaskedTextBox.Focus();
                erro = true;
            }

            if (!erro)
            {
                try
                {
                    String[] horaEvento = FimMaskedTextBox.Text.Split(':');
                    int horas = int.Parse(horaEvento[0]);
                    int minutos = int.Parse(horaEvento[1]);
                    int segundos = 0;
                    entity.Fim = new TimeSpan(horas, minutos, segundos);

                    entity.Descricao = DescricaoTextBox.Text;

                    if (EventoModel.Salvar(entity))
                    {
                        Status = StatusEnum.INCLUIDO;

                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar evento");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro na Hora final");
                    FimMaskedTextBox.Focus();
                }
            }
        }

        private void ExcluirLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Deseja Excluir este evento?", "Exclusao!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (EventoModel.Remover(entity))
                {
                    Status = StatusEnum.REMOVIDO;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Erro ao remover evento");
                }
            }
        }
    }
}
