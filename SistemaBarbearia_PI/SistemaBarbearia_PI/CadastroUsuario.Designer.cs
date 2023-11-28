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
			label1.Location = new Point(11, 111);
			label1.Name = "label1";
			label1.Size = new Size(59, 20);
			label1.TabIndex = 0;
			label1.Text = "Usuário";
			// 
			// TxtUsuario
			// 
			TxtUsuario.Location = new Point(77, 108);
			TxtUsuario.Name = "TxtUsuario";
			TxtUsuario.Size = new Size(534, 27);
			TxtUsuario.TabIndex = 1;
			// 
			// TxtSenha
			// 
			TxtSenha.Location = new Point(67, 141);
			TxtSenha.Name = "TxtSenha";
			TxtSenha.Size = new Size(544, 27);
			TxtSenha.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(11, 144);
			label2.Name = "label2";
			label2.Size = new Size(49, 20);
			label2.TabIndex = 2;
			label2.Text = "Senha";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(11, 177);
			label3.Name = "label3";
			label3.Size = new Size(110, 20);
			label3.TabIndex = 4;
			label3.Text = "Tipo de Acesso";
			// 
			// BtnCadastrar
			// 
			BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
			BtnCadastrar.Location = new Point(128, 278);
			BtnCadastrar.Name = "BtnCadastrar";
			BtnCadastrar.Size = new Size(64, 58);
			BtnCadastrar.TabIndex = 6;
			BtnCadastrar.UseVisualStyleBackColor = true;
			BtnCadastrar.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(14, 27);
			label4.Name = "label4";
			label4.Size = new Size(353, 41);
			label4.TabIndex = 7;
			label4.Text = "Cadastrar Novo Usuário";
			// 
			// CbTipoAcesso
			// 
			CbTipoAcesso.FormattingEnabled = true;
			CbTipoAcesso.Items.AddRange(new object[] { "0 - ADM", "1 - Funcionario" });
			CbTipoAcesso.Location = new Point(128, 173);
			CbTipoAcesso.Margin = new Padding(3, 4, 3, 4);
			CbTipoAcesso.Name = "CbTipoAcesso";
			CbTipoAcesso.Size = new Size(204, 28);
			CbTipoAcesso.TabIndex = 9;
			CbTipoAcesso.Text = "Escolha o tipo de acesso.";
			// 
			// button1
			// 
			button1.Location = new Point(14, 292);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(86, 31);
			button1.TabIndex = 10;
			button1.Text = "Sair";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// FrmCadastroUsuario
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(623, 364);
			Controls.Add(button1);
			Controls.Add(CbTipoAcesso);
			Controls.Add(label4);
			Controls.Add(BtnCadastrar);
			Controls.Add(label3);
			Controls.Add(TxtSenha);
			Controls.Add(label2);
			Controls.Add(TxtUsuario);
			Controls.Add(label1);
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