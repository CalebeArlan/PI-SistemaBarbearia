namespace SistemaBarbearia_PI
{
    partial class CadastraVenda
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
            label5 = new Label();
            label4 = new Label();
            LblTelefone = new Label();
            LblNome = new Label();
            TxtEndereco = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            BtnCadastrar = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 99);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 35;
            label5.Text = "Codigo Funcionario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 26);
            label4.Name = "label4";
            label4.Size = new Size(335, 32);
            label4.TabIndex = 34;
            label4.Text = "Cadastrar Novo Funcionário";
            // 
            // LblTelefone
            // 
            LblTelefone.AutoSize = true;
            LblTelefone.Location = new Point(27, 126);
            LblTelefone.Name = "LblTelefone";
            LblTelefone.Size = new Size(36, 15);
            LblTelefone.TabIndex = 33;
            LblTelefone.Text = "Valor:";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(23, 72);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(92, 15);
            LblNome.TabIndex = 32;
            LblNome.Text = "Codigo Horario:";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(121, 69);
            TxtEndereco.Margin = new Padding(3, 2, 3, 2);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(200, 23);
            TxtEndereco.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 96);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 123);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 38;
            // 
            // button1
            // 
            button1.Location = new Point(27, 356);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 40;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
            BtnCadastrar.Location = new Point(242, 347);
            BtnCadastrar.Margin = new Padding(3, 2, 3, 2);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(56, 41);
            BtnCadastrar.TabIndex = 39;
            BtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // CadastraVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(BtnCadastrar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(TxtEndereco);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LblTelefone);
            Controls.Add(LblNome);
            Name = "CadastraVenda";
            Text = "CadastraVenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label LblTelefone;
        private Label LblNome;
        private TextBox TxtEndereco;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button BtnCadastrar;
    }
}