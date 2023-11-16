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
			label3 = new Label();
			SuspendLayout();
			// 
			// TxtUsuario
			// 
			TxtUsuario.Location = new Point(141, 149);
			TxtUsuario.Name = "TxtUsuario";
			TxtUsuario.Size = new Size(347, 27);
			TxtUsuario.TabIndex = 0;
			// 
			// TxtSenha
			// 
			TxtSenha.Location = new Point(141, 241);
			TxtSenha.Name = "TxtSenha";
			TxtSenha.PasswordChar = '*';
			TxtSenha.Size = new Size(347, 27);
			TxtSenha.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(140, 121);
			label1.Name = "label1";
			label1.Size = new Size(77, 25);
			label1.TabIndex = 2;
			label1.Text = "Usuário";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(140, 213);
			label2.Name = "label2";
			label2.Size = new Size(64, 25);
			label2.TabIndex = 3;
			label2.Text = "Senha";
			// 
			// BtnLogar
			// 
			BtnLogar.BackColor = Color.FromArgb(5, 11, 82);
			BtnLogar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			BtnLogar.ForeColor = SystemColors.ControlLightLight;
			BtnLogar.Location = new Point(141, 331);
			BtnLogar.Name = "BtnLogar";
			BtnLogar.Size = new Size(347, 46);
			BtnLogar.TabIndex = 4;
			BtnLogar.Text = "ENTRAR";
			BtnLogar.UseVisualStyleBackColor = false;
			BtnLogar.Click += button1_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.FromArgb(5, 11, 82);
			label3.Location = new Point(259, 47);
			label3.Name = "label3";
			label3.Size = new Size(110, 46);
			label3.TabIndex = 5;
			label3.Text = "Login";
			// 
			// FrmLoginUsuario
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(629, 451);
			Controls.Add(label3);
			Controls.Add(BtnLogar);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(TxtSenha);
			Controls.Add(TxtUsuario);
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
		private Label label3;
	}
}