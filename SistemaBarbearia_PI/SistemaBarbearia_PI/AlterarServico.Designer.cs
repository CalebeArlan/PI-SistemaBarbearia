namespace SistemaBarbearia_PI
{
	partial class AlterarServico
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
			button1 = new Button();
			label4 = new Label();
			BtnCadastrar = new Button();
			TxtNome = new TextBox();
			LblNome = new Label();
			label5 = new Label();
			TxtPreco = new TextBox();
			LblId = new Label();
			BtnExcluir = new Button();
			TxtDescricao = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(22, 395);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(86, 31);
			button1.TabIndex = 19;
			button1.Text = "Sair";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(24, 25);
			label4.Name = "label4";
			label4.Size = new Size(290, 41);
			label4.TabIndex = 17;
			label4.Text = "Alterar Funcionário";
			// 
			// BtnCadastrar
			// 
			BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
			BtnCadastrar.Location = new Point(267, 383);
			BtnCadastrar.Name = "BtnCadastrar";
			BtnCadastrar.Size = new Size(64, 55);
			BtnCadastrar.TabIndex = 16;
			BtnCadastrar.UseVisualStyleBackColor = true;
			BtnCadastrar.Click += BtnCadastrar_Click;
			// 
			// TxtNome
			// 
			TxtNome.Location = new Point(82, 84);
			TxtNome.Name = "TxtNome";
			TxtNome.Size = new Size(444, 27);
			TxtNome.TabIndex = 12;
			// 
			// LblNome
			// 
			LblNome.AutoSize = true;
			LblNome.Location = new Point(23, 84);
			LblNome.Name = "LblNome";
			LblNome.Size = new Size(53, 20);
			LblNome.TabIndex = 11;
			LblNome.Text = "Nome:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(22, 135);
			label5.Name = "label5";
			label5.Size = new Size(49, 20);
			label5.TabIndex = 31;
			label5.Text = "Preço:";
			label5.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// TxtPreco
			// 
			TxtPreco.Location = new Point(82, 132);
			TxtPreco.Name = "TxtPreco";
			TxtPreco.Size = new Size(444, 27);
			TxtPreco.TabIndex = 32;
			// 
			// LblId
			// 
			LblId.AutoSize = true;
			LblId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			LblId.Location = new Point(346, 25);
			LblId.Name = "LblId";
			LblId.Size = new Size(55, 41);
			LblId.TabIndex = 35;
			LblId.Text = "Id:";
			// 
			// BtnExcluir
			// 
			BtnExcluir.Location = new Point(128, 395);
			BtnExcluir.Margin = new Padding(3, 4, 3, 4);
			BtnExcluir.Name = "BtnExcluir";
			BtnExcluir.Size = new Size(86, 31);
			BtnExcluir.TabIndex = 38;
			BtnExcluir.Text = "Excluir";
			BtnExcluir.UseVisualStyleBackColor = true;
			BtnExcluir.Click += BtnExcluir_Click;
			// 
			// TxtDescricao
			// 
			TxtDescricao.Location = new Point(103, 185);
			TxtDescricao.Multiline = true;
			TxtDescricao.Name = "TxtDescricao";
			TxtDescricao.Size = new Size(423, 115);
			TxtDescricao.TabIndex = 39;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ImageAlign = ContentAlignment.MiddleLeft;
			label1.Location = new Point(22, 185);
			label1.Name = "label1";
			label1.Size = new Size(74, 20);
			label1.TabIndex = 40;
			label1.Text = "Descrição";
			// 
			// AlterarServico
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(TxtDescricao);
			Controls.Add(label1);
			Controls.Add(BtnExcluir);
			Controls.Add(LblId);
			Controls.Add(TxtPreco);
			Controls.Add(label5);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(BtnCadastrar);
			Controls.Add(TxtNome);
			Controls.Add(LblNome);
			Name = "AlterarServico";
			Text = "CadastroFuncionáriocs";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label4;
		private Button BtnCadastrar;
		private Label LblDataNasc;
		private Label LblTelefone;
		private TextBox TxtNome;
		private Label LblNome;
		private TextBox TxtEmail;
		private Label label2;
		private Label label3;
		private MaskedTextBox MtxtTelefone;
		private MaskedTextBox MtxtDataNasc;
		private MaskedTextBox MtxtCPF;
		private MaskedTextBox MtxtRG;
		private Label label5;
		private TextBox TxtPreco;
		private TextBox TxtCargo;
		private Label label6;
		private Label LblId;
		private TextBox TxtSalario;
		private Label label7;
		private Button BtnExcluir;
		private TextBox TxtDescricao;
		private Label label1;
	}
}