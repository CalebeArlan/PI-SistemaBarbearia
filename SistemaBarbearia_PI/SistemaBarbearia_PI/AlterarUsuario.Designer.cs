namespace SistemaBarbearia_PI
{
    partial class AlterarUsuario
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
            BtnSair = new Button();
            CbTipoAcesso = new ComboBox();
            BtnCadastrar = new Button();
            LblTipo = new Label();
            TxtSenha = new TextBox();
            LblSenha = new Label();
            TxtUsuario = new TextBox();
            LblUsuario = new Label();
            label4 = new Label();
            label5 = new Label();
            BtnExcluir = new Button();
            SuspendLayout();
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(41, 248);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(75, 23);
            BtnSair.TabIndex = 19;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // CbTipoAcesso
            // 
            CbTipoAcesso.FormattingEnabled = true;
            CbTipoAcesso.Items.AddRange(new object[] { "0 - ADM", "1 - Funcionario" });
            CbTipoAcesso.Location = new Point(143, 149);
            CbTipoAcesso.Name = "CbTipoAcesso";
            CbTipoAcesso.Size = new Size(179, 23);
            CbTipoAcesso.TabIndex = 18;
            CbTipoAcesso.Text = "Escolha o tipo de acesso.";
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
            BtnCadastrar.Location = new Point(266, 218);
            BtnCadastrar.Margin = new Padding(3, 2, 3, 2);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(56, 53);
            BtnCadastrar.TabIndex = 16;
            BtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // LblTipo
            // 
            LblTipo.AutoSize = true;
            LblTipo.Location = new Point(41, 152);
            LblTipo.Name = "LblTipo";
            LblTipo.Size = new Size(86, 15);
            LblTipo.TabIndex = 15;
            LblTipo.Text = "Tipo de Acesso";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(90, 125);
            TxtSenha.Margin = new Padding(3, 2, 3, 2);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(232, 23);
            TxtSenha.TabIndex = 14;
            // 
            // LblSenha
            // 
            LblSenha.AutoSize = true;
            LblSenha.Location = new Point(41, 127);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(39, 15);
            LblSenha.TabIndex = 13;
            LblSenha.Text = "Senha";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(98, 100);
            TxtUsuario.Margin = new Padding(3, 2, 3, 2);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(223, 23);
            TxtUsuario.TabIndex = 12;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Location = new Point(41, 102);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(47, 15);
            LblUsuario.TabIndex = 11;
            LblUsuario.Text = "Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 34);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 34);
            label5.Name = "label5";
            label5.Size = new Size(188, 32);
            label5.TabIndex = 21;
            label5.Text = "Alterar Usuario";
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(131, 248);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(75, 23);
            BtnExcluir.TabIndex = 22;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // AlterarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnExcluir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BtnSair);
            Controls.Add(CbTipoAcesso);
            Controls.Add(BtnCadastrar);
            Controls.Add(LblTipo);
            Controls.Add(TxtSenha);
            Controls.Add(LblSenha);
            Controls.Add(TxtUsuario);
            Controls.Add(LblUsuario);
            Name = "AlterarUsuario";
            Text = "AlterarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSair;
        private ComboBox CbTipoAcesso;
        private Button BtnCadastrar;
        private Label LblTipo;
        private TextBox TxtSenha;
        private Label LblSenha;
        private TextBox TxtUsuario;
        private Label LblUsuario;
        private Label label4;
        private Label label5;
        private Button BtnExcluir;
    }
}