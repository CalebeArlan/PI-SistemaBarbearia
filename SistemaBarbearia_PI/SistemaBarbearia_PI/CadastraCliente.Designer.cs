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
			MtxtRG.Location = new Point(368, 178);
			MtxtRG.Mask = "99.999.999-9";
			MtxtRG.Name = "MtxtRG";
			MtxtRG.Size = new Size(146, 27);
			MtxtRG.TabIndex = 30;
			// 
			// MtxtCPF
			// 
			MtxtCPF.Location = new Point(66, 178);
			MtxtCPF.Mask = "999.999.999-99";
			MtxtCPF.Name = "MtxtCPF";
			MtxtCPF.Size = new Size(146, 27);
			MtxtCPF.TabIndex = 29;
			// 
			// MtxtDataNasc
			// 
			MtxtDataNasc.Location = new Point(410, 109);
			MtxtDataNasc.Mask = "00/00/0000";
			MtxtDataNasc.Name = "MtxtDataNasc";
			MtxtDataNasc.Size = new Size(104, 27);
			MtxtDataNasc.TabIndex = 27;
			// 
			// MtxtTelefone
			// 
			MtxtTelefone.Location = new Point(86, 109);
			MtxtTelefone.Mask = "(00)00000-0000";
			MtxtTelefone.Name = "MtxtTelefone";
			MtxtTelefone.Size = new Size(126, 27);
			MtxtTelefone.TabIndex = 26;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(315, 181);
			label3.Name = "label3";
			label3.Size = new Size(31, 20);
			label3.TabIndex = 39;
			label3.Text = "RG:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(13, 181);
			label2.Name = "label2";
			label2.Size = new Size(36, 20);
			label2.TabIndex = 38;
			label2.Text = "CPF:";
			// 
			// TxtEmail
			// 
			TxtEmail.Location = new Point(66, 145);
			TxtEmail.Name = "TxtEmail";
			TxtEmail.Size = new Size(449, 27);
			TxtEmail.TabIndex = 28;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(13, 149);
			label1.Name = "label1";
			label1.Size = new Size(49, 20);
			label1.TabIndex = 37;
			label1.Text = "Email:";
			// 
			// button1
			// 
			button1.Location = new Point(12, 255);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(86, 31);
			button1.TabIndex = 32;
			button1.Text = "Sair";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(13, 12);
			label4.Name = "label4";
			label4.Size = new Size(344, 41);
			label4.TabIndex = 36;
			label4.Text = "Cadastrar Novo Cliente";
			// 
			// BtnCadastrar
			// 
			BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
			BtnCadastrar.Location = new Point(123, 243);
			BtnCadastrar.Name = "BtnCadastrar";
			BtnCadastrar.Size = new Size(64, 55);
			BtnCadastrar.TabIndex = 31;
			BtnCadastrar.UseVisualStyleBackColor = true;
			BtnCadastrar.Click += BtnCadastrar_Click;
			// 
			// LblDataNasc
			// 
			LblDataNasc.AutoSize = true;
			LblDataNasc.Location = new Point(257, 112);
			LblDataNasc.Name = "LblDataNasc";
			LblDataNasc.Size = new Size(148, 20);
			LblDataNasc.TabIndex = 35;
			LblDataNasc.Text = "Data de Nascimento:";
			// 
			// LblTelefone
			// 
			LblTelefone.AutoSize = true;
			LblTelefone.Location = new Point(13, 112);
			LblTelefone.Name = "LblTelefone";
			LblTelefone.Size = new Size(69, 20);
			LblTelefone.TabIndex = 34;
			LblTelefone.Text = "Telefone:";
			// 
			// TxtNome
			// 
			TxtNome.Location = new Point(71, 73);
			TxtNome.Name = "TxtNome";
			TxtNome.Size = new Size(444, 27);
			TxtNome.TabIndex = 25;
			// 
			// LblNome
			// 
			LblNome.AutoSize = true;
			LblNome.Location = new Point(13, 76);
			LblNome.Name = "LblNome";
			LblNome.Size = new Size(53, 20);
			LblNome.TabIndex = 33;
			LblNome.Text = "Nome:";
			// 
			// CadastraCliente
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(592, 346);
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
			Margin = new Padding(3, 4, 3, 4);
			Name = "CadastraCliente";
			Text = "Cadastro de Clientes";
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