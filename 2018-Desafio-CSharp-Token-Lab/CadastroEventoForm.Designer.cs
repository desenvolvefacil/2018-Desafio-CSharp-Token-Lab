namespace _2018_Desafio_CSharp_Token_Lab
{
    partial class CadastroEventoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InicioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FimMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescricaoTextBox = new System.Windows.Forms.TextBox();
            this.CadastrarLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ExcluirLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // DataTextBox
            // 
            this.DataTextBox.Enabled = false;
            this.DataTextBox.Location = new System.Drawing.Point(16, 30);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(100, 20);
            this.DataTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora Inicio";
            // 
            // InicioMaskedTextBox
            // 
            this.InicioMaskedTextBox.Location = new System.Drawing.Point(16, 74);
            this.InicioMaskedTextBox.Mask = "90:00";
            this.InicioMaskedTextBox.Name = "InicioMaskedTextBox";
            this.InicioMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.InicioMaskedTextBox.TabIndex = 3;
            // 
            // FimMaskedTextBox
            // 
            this.FimMaskedTextBox.Location = new System.Drawing.Point(16, 114);
            this.FimMaskedTextBox.Mask = "90:00";
            this.FimMaskedTextBox.Name = "FimMaskedTextBox";
            this.FimMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.FimMaskedTextBox.TabIndex = 5;
            this.FimMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Fim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descricao";
            // 
            // DescricaoTextBox
            // 
            this.DescricaoTextBox.Location = new System.Drawing.Point(16, 154);
            this.DescricaoTextBox.Multiline = true;
            this.DescricaoTextBox.Name = "DescricaoTextBox";
            this.DescricaoTextBox.Size = new System.Drawing.Size(267, 104);
            this.DescricaoTextBox.TabIndex = 7;
            // 
            // CadastrarLinkLabel
            // 
            this.CadastrarLinkLabel.AutoSize = true;
            this.CadastrarLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarLinkLabel.Location = new System.Drawing.Point(213, 261);
            this.CadastrarLinkLabel.Name = "CadastrarLinkLabel";
            this.CadastrarLinkLabel.Size = new System.Drawing.Size(70, 17);
            this.CadastrarLinkLabel.TabIndex = 8;
            this.CadastrarLinkLabel.TabStop = true;
            this.CadastrarLinkLabel.Text = "Cadastrar";
            this.CadastrarLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CadastrarLinkLabel_LinkClicked);
            // 
            // ExcluirLinkLabel
            // 
            this.ExcluirLinkLabel.AutoSize = true;
            this.ExcluirLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirLinkLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ExcluirLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.ExcluirLinkLabel.Location = new System.Drawing.Point(16, 261);
            this.ExcluirLinkLabel.Name = "ExcluirLinkLabel";
            this.ExcluirLinkLabel.Size = new System.Drawing.Size(49, 17);
            this.ExcluirLinkLabel.TabIndex = 9;
            this.ExcluirLinkLabel.TabStop = true;
            this.ExcluirLinkLabel.Text = "Excluir";
            this.ExcluirLinkLabel.Visible = false;
            this.ExcluirLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExcluirLinkLabel_LinkClicked);
            // 
            // CadastroEventoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExcluirLinkLabel);
            this.Controls.Add(this.CadastrarLinkLabel);
            this.Controls.Add(this.DescricaoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FimMaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InicioMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CadastroEventoForm";
            this.Text = "CadastroEventoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox InicioMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox FimMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescricaoTextBox;
        private System.Windows.Forms.LinkLabel CadastrarLinkLabel;
        private System.Windows.Forms.LinkLabel ExcluirLinkLabel;
    }
}