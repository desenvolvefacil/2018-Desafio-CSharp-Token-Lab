namespace _2018_Desafio_CSharp_Token_Lab
{
    partial class LoginForm
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.EntarButton = new System.Windows.Forms.Button();
            this.CadastrarLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(78, 48);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(175, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(78, 74);
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.Size = new System.Drawing.Size(175, 20);
            this.SenhaTextBox.TabIndex = 2;
            this.SenhaTextBox.UseSystemPasswordChar = true;
            // 
            // EntarButton
            // 
            this.EntarButton.Location = new System.Drawing.Point(177, 101);
            this.EntarButton.Name = "EntarButton";
            this.EntarButton.Size = new System.Drawing.Size(75, 23);
            this.EntarButton.TabIndex = 4;
            this.EntarButton.Text = "Entrar";
            this.EntarButton.UseVisualStyleBackColor = true;
            this.EntarButton.Click += new System.EventHandler(this.EntarButton_Click);
            // 
            // CadastrarLinkLabel
            // 
            this.CadastrarLinkLabel.AutoSize = true;
            this.CadastrarLinkLabel.Location = new System.Drawing.Point(75, 106);
            this.CadastrarLinkLabel.Name = "CadastrarLinkLabel";
            this.CadastrarLinkLabel.Size = new System.Drawing.Size(52, 13);
            this.CadastrarLinkLabel.TabIndex = 5;
            this.CadastrarLinkLabel.TabStop = true;
            this.CadastrarLinkLabel.Text = "Cadastrar";
            this.CadastrarLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CadastrarLinkLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 192);
            this.Controls.Add(this.CadastrarLinkLabel);
            this.Controls.Add(this.EntarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SenhaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SenhaTextBox;
        private System.Windows.Forms.Button EntarButton;
        private System.Windows.Forms.LinkLabel CadastrarLinkLabel;
    }
}

