namespace SistemaBarbearia_PI
{
    partial class AlterarCliente
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
            label4 = new Label();
            MtxtTelefone = new MaskedTextBox();
            LblTelefone = new Label();
            TxtNome = new TextBox();
            LblNome = new Label();
            TxtEmail = new TextBox();
            label1 = new Label();
            MtxtDataNasc = new MaskedTextBox();
            label2 = new Label();
            MtxtRG = new MaskedTextBox();
            label3 = new Label();
            MtxtCPF = new MaskedTextBox();
            label5 = new Label();
            BtnExcluir = new Button();
            button1 = new Button();
            BtnCadastrar = new Button();
            LblId = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(176, 32);
            label4.TabIndex = 18;
            label4.Text = "Alterar cliente";
            // 
            // MtxtTelefone
            // 
            MtxtTelefone.Location = new Point(72, 79);
            MtxtTelefone.Margin = new Padding(3, 2, 3, 2);
            MtxtTelefone.Mask = "(00)00000-0000";
            MtxtTelefone.Name = "MtxtTelefone";
            MtxtTelefone.Size = new Size(153, 23);
            MtxtTelefone.TabIndex = 31;
            // 
            // LblTelefone
            // 
            LblTelefone.AutoSize = true;
            LblTelefone.Location = new Point(12, 82);
            LblTelefone.Name = "LblTelefone";
            LblTelefone.Size = new Size(54, 15);
            LblTelefone.TabIndex = 30;
            LblTelefone.Text = "Telefone:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(61, 52);
            TxtNome.Margin = new Padding(3, 2, 3, 2);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(389, 23);
            TxtNome.TabIndex = 29;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(12, 55);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(43, 15);
            LblNome.TabIndex = 28;
            LblNome.Text = "Nome:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(61, 106);
            TxtEmail.Margin = new Padding(3, 2, 3, 2);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(205, 23);
            TxtEmail.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 32;
            label1.Text = "Email:";
            // 
            // MtxtDataNasc
            // 
            MtxtDataNasc.Location = new Point(135, 133);
            MtxtDataNasc.Margin = new Padding(3, 2, 3, 2);
            MtxtDataNasc.Mask = "99/99/9999";
            MtxtDataNasc.Name = "MtxtDataNasc";
            MtxtDataNasc.Size = new Size(153, 23);
            MtxtDataNasc.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 34;
            label2.Text = "Data de Nascimento:";
            // 
            // MtxtRG
            // 
            MtxtRG.Location = new Point(43, 187);
            MtxtRG.Margin = new Padding(3, 2, 3, 2);
            MtxtRG.Mask = "99.999.999-9";
            MtxtRG.Name = "MtxtRG";
            MtxtRG.Size = new Size(153, 23);
            MtxtRG.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 190);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 38;
            label3.Text = "RG:";
            // 
            // MtxtCPF
            // 
            MtxtCPF.Location = new Point(49, 160);
            MtxtCPF.Margin = new Padding(3, 2, 3, 2);
            MtxtCPF.Mask = "999.999.999-99";
            MtxtCPF.Name = "MtxtCPF";
            MtxtCPF.Size = new Size(153, 23);
            MtxtCPF.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 36;
            label5.Text = "CPF:";
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(105, 283);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(75, 23);
            BtnExcluir.TabIndex = 42;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 283);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 41;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
            BtnCadastrar.Location = new Point(227, 274);
            BtnCadastrar.Margin = new Padding(3, 2, 3, 2);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(56, 41);
            BtnCadastrar.TabIndex = 40;
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblId.Location = new Point(217, 9);
            LblId.Name = "LblId";
            LblId.Size = new Size(37, 32);
            LblId.TabIndex = 43;
            LblId.Text = "Id";
            // 
            // AlterarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 344);
            Controls.Add(LblId);
            Controls.Add(BtnExcluir);
            Controls.Add(button1);
            Controls.Add(BtnCadastrar);
            Controls.Add(MtxtRG);
            Controls.Add(label3);
            Controls.Add(MtxtCPF);
            Controls.Add(label5);
            Controls.Add(MtxtDataNasc);
            Controls.Add(label2);
            Controls.Add(TxtEmail);
            Controls.Add(label1);
            Controls.Add(MtxtTelefone);
            Controls.Add(LblTelefone);
            Controls.Add(TxtNome);
            Controls.Add(LblNome);
            Controls.Add(label4);
            Name = "AlterarCliente";
            Text = "AlterarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private MaskedTextBox MtxtTelefone;
        private Label LblTelefone;
        private TextBox TxtNome;
        private Label LblNome;
        private TextBox TxtEmail;
        private Label label1;
        private MaskedTextBox MtxtDataNasc;
        private Label label2;
        private MaskedTextBox MtxtRG;
        private Label label3;
        private MaskedTextBox MtxtCPF;
        private Label label5;
        private Button BtnExcluir;
        private Button button1;
        private Button BtnCadastrar;
        private Label LblId;
    }
}