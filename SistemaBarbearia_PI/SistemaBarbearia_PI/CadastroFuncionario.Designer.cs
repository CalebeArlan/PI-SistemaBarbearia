namespace SistemaBarbearia_PI
{
	partial class CadastroFuncionario
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
			LblDataNasc = new Label();
			LblTelefone = new Label();
			TxtNome = new TextBox();
			LblNome = new Label();
			TxtEmail = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			MtxtTelefone = new MaskedTextBox();
			MtxtDataNasc = new MaskedTextBox();
			MtxtCPF = new MaskedTextBox();
			MtxtRG = new MaskedTextBox();
			label5 = new Label();
			TxtEndereco = new TextBox();
			TxtCargo = new TextBox();
			label6 = new Label();
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
			label4.Size = new Size(411, 41);
			label4.TabIndex = 17;
			label4.Text = "Cadastrar Novo Funcionário";
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
			// LblDataNasc
			// 
			LblDataNasc.AutoSize = true;
			LblDataNasc.Location = new Point(26, 205);
			LblDataNasc.Name = "LblDataNasc";
			LblDataNasc.Size = new Size(148, 20);
			LblDataNasc.TabIndex = 15;
			LblDataNasc.Text = "Data de Nascimento:";
			// 
			// LblTelefone
			// 
			LblTelefone.AutoSize = true;
			LblTelefone.Location = new Point(26, 169);
			LblTelefone.Name = "LblTelefone";
			LblTelefone.Size = new Size(69, 20);
			LblTelefone.TabIndex = 13;
			LblTelefone.Text = "Telefone:";
			// 
			// TxtNome
			// 
			TxtNome.Location = new Point(81, 100);
			TxtNome.Name = "TxtNome";
			TxtNome.Size = new Size(444, 27);
			TxtNome.TabIndex = 12;
			// 
			// LblNome
			// 
			LblNome.AutoSize = true;
			LblNome.Location = new Point(22, 100);
			LblNome.Name = "LblNome";
			LblNome.Size = new Size(53, 20);
			LblNome.TabIndex = 11;
			LblNome.Text = "Nome:";
			// 
			// TxtEmail
			// 
			TxtEmail.Location = new Point(81, 235);
			TxtEmail.Name = "TxtEmail";
			TxtEmail.Size = new Size(228, 27);
			TxtEmail.TabIndex = 21;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(26, 238);
			label1.Name = "label1";
			label1.Size = new Size(49, 20);
			label1.TabIndex = 20;
			label1.Text = "Email:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(27, 271);
			label2.Name = "label2";
			label2.Size = new Size(36, 20);
			label2.TabIndex = 22;
			label2.Text = "CPF:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(29, 304);
			label3.Name = "label3";
			label3.Size = new Size(31, 20);
			label3.TabIndex = 24;
			label3.Text = "RG:";
			// 
			// MtxtTelefone
			// 
			MtxtTelefone.Location = new Point(101, 166);
			MtxtTelefone.Mask = "(00)00000-0000";
			MtxtTelefone.Name = "MtxtTelefone";
			MtxtTelefone.Size = new Size(174, 27);
			MtxtTelefone.TabIndex = 27;
			// 
			// MtxtDataNasc
			// 
			MtxtDataNasc.Location = new Point(177, 202);
			MtxtDataNasc.Mask = "00/00/0000";
			MtxtDataNasc.Name = "MtxtDataNasc";
			MtxtDataNasc.Size = new Size(174, 27);
			MtxtDataNasc.TabIndex = 28;
			// 
			// MtxtCPF
			// 
			MtxtCPF.Location = new Point(81, 268);
			MtxtCPF.Mask = "000.000.000-00";
			MtxtCPF.Name = "MtxtCPF";
			MtxtCPF.Size = new Size(174, 27);
			MtxtCPF.TabIndex = 29;
			// 
			// MtxtRG
			// 
			MtxtRG.Location = new Point(81, 301);
			MtxtRG.Mask = "00.000.000-0";
			MtxtRG.Name = "MtxtRG";
			MtxtRG.Size = new Size(174, 27);
			MtxtRG.TabIndex = 30;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(26, 136);
			label5.Name = "label5";
			label5.Size = new Size(71, 20);
			label5.TabIndex = 31;
			label5.Text = "Endereço";
			// 
			// TxtEndereco
			// 
			TxtEndereco.Location = new Point(103, 133);
			TxtEndereco.Name = "TxtEndereco";
			TxtEndereco.Size = new Size(228, 27);
			TxtEndereco.TabIndex = 32;
			// 
			// TxtCargo
			// 
			TxtCargo.Location = new Point(81, 334);
			TxtCargo.Name = "TxtCargo";
			TxtCargo.Size = new Size(228, 27);
			TxtCargo.TabIndex = 34;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(26, 337);
			label6.Name = "label6";
			label6.Size = new Size(52, 20);
			label6.TabIndex = 33;
			label6.Text = "Cargo:";
			// 
			// CadastroFuncionario
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(TxtCargo);
			Controls.Add(label6);
			Controls.Add(TxtEndereco);
			Controls.Add(label5);
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
			Name = "CadastroFuncionario";
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
		private Label label1;
		private Label label2;
		private Label label3;
		private MaskedTextBox MtxtTelefone;
		private MaskedTextBox MtxtDataNasc;
		private MaskedTextBox MtxtCPF;
		private MaskedTextBox MtxtRG;
		private Label label5;
		private TextBox TxtEndereco;
		private TextBox TxtCargo;
		private Label label6;
	}
}