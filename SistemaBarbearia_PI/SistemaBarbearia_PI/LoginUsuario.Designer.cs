namespace SistemaBarbearia_PI
{
    partial class FrmLoginUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtUsuario = new TextBox();
            TxtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnLogar = new Button();
            SuspendLayout();
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(120, 112);
            TxtUsuario.Margin = new Padding(3, 2, 3, 2);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(304, 23);
            TxtUsuario.TabIndex = 0;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(120, 181);
            TxtSenha.Margin = new Padding(3, 2, 3, 2);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(304, 23);
            TxtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 83);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 164);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // BtnLogar
            // 
            BtnLogar.Image = Properties.Resources.icons8_ok_48;
            BtnLogar.Location = new Point(239, 231);
            BtnLogar.Margin = new Padding(3, 2, 3, 2);
            BtnLogar.Name = "BtnLogar";
            BtnLogar.Size = new Size(56, 50);
            BtnLogar.TabIndex = 4;
            BtnLogar.UseVisualStyleBackColor = true;
            BtnLogar.Click += button1_Click;
            // 
            // FrmLoginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 338);
            Controls.Add(BtnLogar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtSenha);
            Controls.Add(TxtUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLoginUsuario";
            Text = "Login Usuario - Barbearia";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUsuario;
        private TextBox TxtSenha;
        private Label label1;
        private Label label2;
        private Button BtnLogar;
    }
}