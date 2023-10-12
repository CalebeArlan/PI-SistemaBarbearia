namespace SistemaBarbearia_PI
{
    partial class FrmCadastroUsuario
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
            label1 = new Label();
            TxtUsuario = new TextBox();
            TxtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BtnCadastrar = new Button();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            CbTipoAcesso = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 83);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(67, 81);
            TxtUsuario.Margin = new Padding(3, 2, 3, 2);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(223, 23);
            TxtUsuario.TabIndex = 1;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(59, 106);
            TxtSenha.Margin = new Padding(3, 2, 3, 2);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(232, 23);
            TxtSenha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 108);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 133);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de Acesso";
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
            BtnCadastrar.Location = new Point(235, 199);
            BtnCadastrar.Margin = new Padding(3, 2, 3, 2);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(56, 53);
            BtnCadastrar.TabIndex = 6;
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 22);
            label4.Name = "label4";
            label4.Size = new Size(287, 32);
            label4.TabIndex = 7;
            label4.Text = "Cadastrar Novo Usuário";
            // 
            // CbTipoAcesso
            // 
            CbTipoAcesso.FormattingEnabled = true;
            CbTipoAcesso.Items.AddRange(new object[] { "0 - ADM", "1 - Funcionario" });
            CbTipoAcesso.Location = new Point(112, 130);
            CbTipoAcesso.Name = "CbTipoAcesso";
            CbTipoAcesso.Size = new Size(179, 23);
            CbTipoAcesso.TabIndex = 9;
            CbTipoAcesso.Text = "Escolha o tipo de acesso.";
            // 
            // button1
            // 
            button1.Location = new Point(10, 229);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(CbTipoAcesso);
            Controls.Add(label4);
            Controls.Add(BtnCadastrar);
            Controls.Add(label3);
            Controls.Add(TxtSenha);
            Controls.Add(label2);
            Controls.Add(TxtUsuario);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro de Usuarios - Barbearia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtUsuario;
        private TextBox TxtSenha;
        private Label label2;
        private Label label3;
        private Button BtnCadastrar;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox CbTipoAcesso;
        private Button button1;
    }
}