namespace SistemaBarbearia_PI
{
    partial class CadastraCliente
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
            MtxtRG = new MaskedTextBox();
            MtxtCPF = new MaskedTextBox();
            MtxtDataNasc = new MaskedTextBox();
            MtxtTelefone = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            TxtEmail = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label4 = new Label();
            BtnCadastrar = new Button();
            LblDataNasc = new Label();
            LblTelefone = new Label();
            TxtNome = new TextBox();
            LblNome = new Label();
            SuspendLayout();
            // 
            // MtxtRG
            // 
            MtxtRG.Location = new Point(62, 188);
            MtxtRG.Margin = new Padding(3, 2, 3, 2);
            MtxtRG.Mask = "999.999.999-99";
            MtxtRG.Name = "MtxtRG";
            MtxtRG.Size = new Size(153, 23);
            MtxtRG.TabIndex = 30;
            // 
            // MtxtCPF
            // 
            MtxtCPF.Location = new Point(62, 163);
            MtxtCPF.Margin = new Padding(3, 2, 3, 2);
            MtxtCPF.Mask = "999.999.999-99";
            MtxtCPF.Name = "MtxtCPF";
            MtxtCPF.Size = new Size(153, 23);
            MtxtCPF.TabIndex = 29;
            // 
            // MtxtDataNasc
            // 
            MtxtDataNasc.Location = new Point(145, 136);
            MtxtDataNasc.Margin = new Padding(3, 2, 3, 2);
            MtxtDataNasc.Mask = "00/00/0000";
            MtxtDataNasc.Name = "MtxtDataNasc";
            MtxtDataNasc.Size = new Size(153, 23);
            MtxtDataNasc.TabIndex = 27;
            // 
            // MtxtTelefone
            // 
            MtxtTelefone.Location = new Point(75, 82);
            MtxtTelefone.Margin = new Padding(3, 2, 3, 2);
            MtxtTelefone.Mask = "(00)00000-0000";
            MtxtTelefone.Name = "MtxtTelefone";
            MtxtTelefone.Size = new Size(153, 23);
            MtxtTelefone.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 190);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 39;
            label3.Text = "RG:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 166);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 38;
            label2.Text = "CPF:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(62, 109);
            TxtEmail.Margin = new Padding(3, 2, 3, 2);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(200, 23);
            TxtEmail.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 112);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 37;
            label1.Text = "Email:";
            // 
            // button1
            // 
            button1.Location = new Point(10, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(278, 32);
            label4.TabIndex = 36;
            label4.Text = "Cadastrar Novo Cliente";
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
            BtnCadastrar.Location = new Point(225, 277);
            BtnCadastrar.Margin = new Padding(3, 2, 3, 2);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(56, 41);
            BtnCadastrar.TabIndex = 31;
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // LblDataNasc
            // 
            LblDataNasc.AutoSize = true;
            LblDataNasc.Location = new Point(13, 138);
            LblDataNasc.Name = "LblDataNasc";
            LblDataNasc.Size = new Size(117, 15);
            LblDataNasc.TabIndex = 35;
            LblDataNasc.Text = "Data de Nascimento:";
            // 
            // LblTelefone
            // 
            LblTelefone.AutoSize = true;
            LblTelefone.Location = new Point(10, 84);
            LblTelefone.Name = "LblTelefone";
            LblTelefone.Size = new Size(54, 15);
            LblTelefone.TabIndex = 34;
            LblTelefone.Text = "Telefone:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(62, 55);
            TxtNome.Margin = new Padding(3, 2, 3, 2);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(389, 23);
            TxtNome.TabIndex = 25;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(10, 55);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(43, 15);
            LblNome.TabIndex = 33;
            LblNome.Text = "Nome:";
            // 
            // CadastraCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 409);
            Controls.Add(MtxtRG);
            Controls.Add(MtxtCPF);
            Controls.Add(MtxtDataNasc);
            Controls.Add(MtxtTelefone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtEmail);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(BtnCadastrar);
            Controls.Add(LblDataNasc);
            Controls.Add(LblTelefone);
            Controls.Add(TxtNome);
            Controls.Add(LblNome);
            Name = "CadastraCliente";
            Text = "CadastraCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox MtxtRG;
        private MaskedTextBox MtxtCPF;
        private MaskedTextBox MtxtDataNasc;
        private MaskedTextBox MtxtTelefone;
        private Label label3;
        private Label label2;
        private TextBox TxtEmail;
        private Label label1;
        private Button button1;
        private Label label4;
        private Button BtnCadastrar;
        private Label LblDataNasc;
        private Label LblTelefone;
        private TextBox TxtNome;
        private Label LblNome;
    }
}