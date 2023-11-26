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
			BtnCadastrar = new Button();
			LblTipo = new Label();
			TxtSenha = new TextBox();
			LblSenha = new Label();
			TxtUsuario = new TextBox();
			LblUsuario = new Label();
			label4 = new Label();
			label5 = new Label();
			BtnExcluir = new Button();
			LblId = new Label();
			CbTipoAcesso = new ComboBox();
			SuspendLayout();
			// 
			// BtnSair
			// 
			BtnSair.Location = new Point(37, 211);
			BtnSair.Margin = new Padding(3, 4, 3, 4);
			BtnSair.Name = "BtnSair";
			BtnSair.Size = new Size(86, 31);
			BtnSair.TabIndex = 19;
			BtnSair.Text = "Sair";
			BtnSair.UseVisualStyleBackColor = true;
			BtnSair.Click += BtnSair_Click;
			// 
			// BtnCadastrar
			// 
			BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
			BtnCadastrar.Location = new Point(285, 199);
			BtnCadastrar.Name = "BtnCadastrar";
			BtnCadastrar.Size = new Size(64, 55);
			BtnCadastrar.TabIndex = 16;
			BtnCadastrar.UseVisualStyleBackColor = true;
			BtnCadastrar.Click += BtnCadastrar_Click;
			// 
			// LblTipo
			// 
			LblTipo.AutoSize = true;
			LblTipo.Location = new Point(37, 156);
			LblTipo.Name = "LblTipo";
			LblTipo.Size = new Size(110, 20);
			LblTipo.TabIndex = 15;
			LblTipo.Text = "Tipo de Acesso";
			// 
			// TxtSenha
			// 
			TxtSenha.Location = new Point(93, 120);
			TxtSenha.Name = "TxtSenha";
			TxtSenha.Size = new Size(662, 27);
			TxtSenha.TabIndex = 14;
			// 
			// LblSenha
			// 
			LblSenha.AutoSize = true;
			LblSenha.Location = new Point(37, 122);
			LblSenha.Name = "LblSenha";
			LblSenha.Size = new Size(49, 20);
			LblSenha.TabIndex = 13;
			LblSenha.Text = "Senha";
			// 
			// TxtUsuario
			// 
			TxtUsuario.Location = new Point(102, 86);
			TxtUsuario.Name = "TxtUsuario";
			TxtUsuario.Size = new Size(651, 27);
			TxtUsuario.TabIndex = 12;
			// 
			// LblUsuario
			// 
			LblUsuario.AutoSize = true;
			LblUsuario.Location = new Point(37, 89);
			LblUsuario.Name = "LblUsuario";
			LblUsuario.Size = new Size(59, 20);
			LblUsuario.TabIndex = 11;
			LblUsuario.Text = "Usuário";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(129, 45);
			label4.Name = "label4";
			label4.Size = new Size(0, 20);
			label4.TabIndex = 20;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(37, 28);
			label5.Name = "label5";
			label5.Size = new Size(232, 41);
			label5.TabIndex = 21;
			label5.Text = "Alterar Usuario";
			// 
			// BtnExcluir
			// 
			BtnExcluir.Location = new Point(142, 211);
			BtnExcluir.Margin = new Padding(3, 4, 3, 4);
			BtnExcluir.Name = "BtnExcluir";
			BtnExcluir.Size = new Size(86, 31);
			BtnExcluir.TabIndex = 22;
			BtnExcluir.Text = "Excluir";
			BtnExcluir.UseVisualStyleBackColor = true;
			BtnExcluir.Click += BtnExcluir_Click;
			// 
			// LblId
			// 
			LblId.AutoSize = true;
			LblId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			LblId.Location = new Point(294, 28);
			LblId.Name = "LblId";
			LblId.Size = new Size(55, 41);
			LblId.TabIndex = 23;
			LblId.Text = "Id:";
			LblId.Visible = false;
			// 
			// CbTipoAcesso
			// 
			CbTipoAcesso.FormattingEnabled = true;
			CbTipoAcesso.Items.AddRange(new object[] { "0 - ADM", "1 - Funcionario" });
			CbTipoAcesso.Location = new Point(153, 152);
			CbTipoAcesso.Margin = new Padding(3, 4, 3, 4);
			CbTipoAcesso.Name = "CbTipoAcesso";
			CbTipoAcesso.Size = new Size(222, 28);
			CbTipoAcesso.TabIndex = 18;
			CbTipoAcesso.Text = "Escolha o tipo de acesso.";
			// 
			// AlterarUsuario
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(784, 316);
			Controls.Add(LblId);
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
			Margin = new Padding(3, 4, 3, 4);
			Name = "AlterarUsuario";
			Text = "AlterarUsuario";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button BtnSair;
		private Button BtnCadastrar;
		private Label LblTipo;
		private TextBox TxtSenha;
		private Label LblSenha;
		private TextBox TxtUsuario;
		private Label LblUsuario;
		private Label label4;
		private Label label5;
		private Button BtnExcluir;
		private Label LblId;
		private ComboBox CbTipoAcesso;
	}
}