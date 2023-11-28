namespace SistemaBarbearia_PI
{
	partial class Menu
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			statusStrip1 = new StatusStrip();
			menuStrip1 = new MenuStrip();
			aToolStripMenuItem = new ToolStripMenuItem();
			sairToolStripMenuItem = new ToolStripMenuItem();
			BtnCadastrarFuncionario = new Button();
			imageList1 = new ImageList(components);
			BtnPesquisarFuncionario = new Button();
			BtnCadastrarCliente = new Button();
			BtnPesquisarCliente = new Button();
			BtnPesquisarUsuario = new Button();
			BtnCadastrarUsuário = new Button();
			BtnPesquisarServico = new Button();
			BtnCadastrarServiço = new Button();
			BtnPesquisarHorario = new Button();
			BtnCadastrarHorario = new Button();
			LblModoDashboard = new Label();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(20, 20);
			statusStrip1.Location = new Point(0, 472);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Padding = new Padding(1, 0, 16, 0);
			statusStrip1.Size = new Size(1127, 22);
			statusStrip1.TabIndex = 0;
			statusStrip1.Text = "Sistema de Gestão e Agendamento de Barbearia  v4.1";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(7, 3, 0, 3);
			menuStrip1.Size = new Size(1127, 30);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// aToolStripMenuItem
			// 
			aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
			aToolStripMenuItem.Name = "aToolStripMenuItem";
			aToolStripMenuItem.Size = new Size(75, 24);
			aToolStripMenuItem.Text = "Arquivo";
			// 
			// sairToolStripMenuItem
			// 
			sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			sairToolStripMenuItem.Size = new Size(224, 26);
			sairToolStripMenuItem.Text = "Sair";
			sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
			// 
			// BtnCadastrarFuncionario
			// 
			BtnCadastrarFuncionario.BackColor = Color.FromArgb(5, 11, 82);
			BtnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
			BtnCadastrarFuncionario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			BtnCadastrarFuncionario.ForeColor = SystemColors.ButtonHighlight;
			BtnCadastrarFuncionario.ImageKey = "icons8-crachá-50_branco.png";
			BtnCadastrarFuncionario.ImageList = imageList1;
			BtnCadastrarFuncionario.Location = new Point(886, 247);
			BtnCadastrarFuncionario.Name = "BtnCadastrarFuncionario";
			BtnCadastrarFuncionario.Padding = new Padding(1);
			BtnCadastrarFuncionario.Size = new Size(212, 93);
			BtnCadastrarFuncionario.TabIndex = 2;
			BtnCadastrarFuncionario.Text = "Cadastrar Funcionário";
			BtnCadastrarFuncionario.TextImageRelation = TextImageRelation.ImageAboveText;
			BtnCadastrarFuncionario.UseVisualStyleBackColor = false;
			BtnCadastrarFuncionario.Click += button1_Click;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth8Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName(0, "icons8-crachá-50_branco.png");
			imageList1.Images.SetKeyName(1, "icons8-gestão-de-cliente-50_branco.png");
			imageList1.Images.SetKeyName(2, "UserVector_Branco.png");
			imageList1.Images.SetKeyName(3, "Servico_Icone_Branco.png");
			imageList1.Images.SetKeyName(4, "Calendario-Icone_Branco.png");
			// 
			// BtnPesquisarFuncionario
			// 
			BtnPesquisarFuncionario.BackColor = Color.FromArgb(5, 11, 82);
			BtnPesquisarFuncionario.FlatAppearance.BorderSize = 0;
			BtnPesquisarFuncionario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			BtnPesquisarFuncionario.ForeColor = SystemColors.ButtonHighlight;
			BtnPesquisarFuncionario.ImageKey = "icons8-crachá-50_branco.png";
			BtnPesquisarFuncionario.ImageList = imageList1;
			BtnPesquisarFuncionario.Location = new Point(886, 346);
			BtnPesquisarFuncionario.Name = "BtnPesquisarFuncionario";
			BtnPesquisarFuncionario.Padding = new Padding(1);
			BtnPesquisarFuncionario.Size = new Size(212, 93);
			BtnPesquisarFuncionario.TabIndex = 3;
			BtnPesquisarFuncionario.Text = "Pesquisar Funcionário";
			BtnPesquisarFuncionario.TextImageRelation = TextImageRelation.ImageAboveText;
			BtnPesquisarFuncionario.UseVisualStyleBackColor = false;
			BtnPesquisarFuncionario.Click += button2_Click;
			// 
			// BtnCadastrarCliente
			// 
			BtnCadastrarCliente.BackColor = Color.FromArgb(5, 11, 82);
			BtnCadastrarCliente.FlatAppearance.BorderSize = 0;
			BtnCadastrarCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			BtnCadastrarCliente.ForeColor = SystemColors.ButtonHighlight;
			BtnCadastrarCliente.ImageKey = "icons8-gestão-de-cliente-50_branco.png";
			BtnCadastrarCliente.ImageList = imageList1;
			BtnCadastrarCliente.Location = new Point(235, 247);
			BtnCadastrarCliente.Name = "BtnCadastrarCliente";
			BtnCadastrarCliente.Padding = new Padding(1);
			BtnCadastrarCliente.Size = new Size(212, 93);
			BtnCadastrarCliente.TabIndex = 4;
			BtnCadastrarCliente.Text = "Cadastrar Cliente";
			BtnCadastrarCliente.TextImageRelation = TextImageRelation.ImageAboveText;
			BtnCadastrarCliente.UseVisualStyleBackColor = false;
			BtnCadastrarCliente.Click += button3_Click;
			// 
			// BtnPesquisarCliente
			// 
			BtnPesquisarCliente.BackColor = Color.FromArgb(5, 11, 82);
			BtnPesquisarCliente.FlatAppearance.BorderSize = 0;
			BtnPesquisarCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			BtnPesquisarCliente.ForeColor = SystemColors.ButtonHighlight;
			BtnPesquisarCliente.ImageKey = "icons8-gestão-de-cliente-50_branco.png";
			BtnPesquisarCliente.ImageList = imageList1;
			BtnPesquisarCliente.Location = new Point(235, 346);
			BtnPesquisarCliente.Name = "BtnPesquisarCliente";
			BtnPesquisarCliente.Padding = new Padding(1);
			BtnPesquisarCliente.Size = new Size(212, 93);
			BtnPesquisarCliente.TabIndex = 5;
			BtnPesquisarCliente.Text = "Pesquisar Cliente";
			BtnPesquisarCliente.TextImageRelation = TextImageRelation.ImageAboveText;
			BtnPesquisarCliente.UseVisualStyleBackColor = false;
			BtnPesquisarCliente.Click += button4_Click;
			// 
			// BtnPesquisarUsuario
			// 
			BtnPesquisarUsuario.BackColor = Color.FromArgb(5, 11, 82);
			BtnPesquisarUsuario.FlatAppearance.BorderSize = 0;
			BtnPesquisarUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			BtnPesquisarUsuario.ForeColor = SystemColors.ButtonHighlight;
			BtnPesquisarUsuario.ImageKey = "UserVector_Branco.png";
			BtnPesquisarUsuario.ImageList = imageList1;
			BtnPesquisarUsuario.Location = new Point(18, 346);
			BtnPesquisarUsuario.Name = "BtnPesquisarUsuario";
			BtnPesquisarUsuario.Padding = new Padding(1);
			BtnPesquisarUsuario.Size = new Size(212, 93);
			BtnPesquisarUsuario.TabIndex = 7;
			BtnPesquisarUsuario.Text = "Pesquisar Usuário";
			BtnPesquisarUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
			BtnPesquisarUsuario.UseVisualStyleBackColor = false;
			BtnPesquisarUsuario.Click += button5_Click;
			// 
			// BtnCadastrarUsuário
			// 
			BtnCadastrarUsuário.BackColor = Color.FromArgb(5, 11, 82);
			BtnCadastrarUsuário.FlatAppearance.BorderSize = 0;
			BtnCadastrarUsuário.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			BtnCadastrarUsuário.ForeColor = SystemColors.ButtonHighlight;
			BtnCadastrarUsuário.ImageKey = "UserVector_Branco.png";
			BtnCadastrarUsuário.ImageList = imageList1;
			BtnCadastrarUsuário.Location = new Point(18, 247);
			BtnCadastrarUsuário.Name = "BtnCadastrarUsuário";
			BtnCadastrarUsuário.Padding = new Padding(1);
			BtnCadastrarUsuário.Size = new Size(212, 93);
			BtnCadastrarUsuário.TabIndex = 6;
			BtnCadastrarUsuário.Text = "Cadastrar Usuário";
			BtnCadastrarUsuário.TextImageRelation = TextImageRelation.ImageAboveText;
			BtnCadastrarUsuário.UseVisualStyleBackColor = false;
			BtnCadastrarUsuário.Click += button6_Click;
			// 
			// BtnPesquisarServico
			// 
			BtnPesquisarServico.BackColor = Color.FromArgb(5, 11, 82);
			BtnPesquisarServico.FlatAppearance.BorderSize = 0;
			BtnPesquisarServico.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			BtnPesquisarServico.ForeColor = SystemColors.ButtonHighlight;
			BtnPesquisarServico.ImageKey = "Servico_Icone_Branco.png";
			BtnPesquisarServico.ImageList = imageList1;
			BtnPesquisarServico.Location = new Point(452, 346);
			BtnPesquisarServico.Name = "BtnPesquisarServico";
			BtnPesquisarServico.Padding = new Padding(1);
			BtnPesquisarServico.Size = new Size(212, 93);
			BtnPesquisarServico.TabIndex = 9;
			BtnPesquisarServico.Text = "Pesquisar Serviço";
			BtnPesquisarServico.TextImageRelation = TextImageRelation.ImageAboveText;
			BtnPesquisarServico.UseVisualStyleBackColor = false;
			BtnPesquisarServico.Click += button7_Click;
			// 
			// BtnCadastrarServiço
			// 
			BtnCadastrarServiço.BackColor = Color.FromArgb(5, 11, 82);
			BtnCadastrarServiço.FlatAppearance.BorderSize = 0;
			BtnCadastrarServiço.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			BtnCadastrarServiço.ForeColor = SystemColors.ButtonHighlight;
			BtnCadastrarServiço.ImageKey = "Servico_Icone_Branco.png";
			BtnCadastrarServiço.ImageList = imageList1;
			BtnCadastrarServiço.Location = new Point(452, 247);
			BtnCadastrarServiço.Name = "BtnCadastrarServiço";
			BtnCadastrarServiço.Padding = new Padding(1);
			BtnCadastrarServiço.Size = new Size(212, 93);
			BtnCadastrarServiço.TabIndex = 8;
			BtnCadastrarServiço.Text = "Cadastrar Serviço";
			BtnCadastrarServiço.TextImageRelation = TextImageRelation.ImageAboveText;
			BtnCadastrarServiço.UseVisualStyleBackColor = false;
			BtnCadastrarServiço.Click += button8_Click;
			// 
			// BtnPesquisarHorario
			// 
			BtnPesquisarHorario.BackColor = Color.FromArgb(5, 11, 82);
			BtnPesquisarHorario.FlatAppearance.BorderSize = 0;
			BtnPesquisarHorario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			BtnPesquisarHorario.ForeColor = SystemColors.ButtonHighlight;
			BtnPesquisarHorario.ImageKey = "Calendario-Icone_Branco.png";
			BtnPesquisarHorario.ImageList = imageList1;
			BtnPesquisarHorario.Location = new Point(669, 346);
			BtnPesquisarHorario.Name = "BtnPesquisarHorario";
			BtnPesquisarHorario.Padding = new Padding(1);
			BtnPesquisarHorario.Size = new Size(212, 93);
			BtnPesquisarHorario.TabIndex = 11;
			BtnPesquisarHorario.Text = "Pesquisar Horário";
			BtnPesquisarHorario.TextImageRelation = TextImageRelation.ImageAboveText;
			BtnPesquisarHorario.UseVisualStyleBackColor = false;
			BtnPesquisarHorario.Click += button9_Click;
			// 
			// BtnCadastrarHorario
			// 
			BtnCadastrarHorario.BackColor = Color.FromArgb(5, 11, 82);
			BtnCadastrarHorario.FlatAppearance.BorderSize = 0;
			BtnCadastrarHorario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			BtnCadastrarHorario.ForeColor = SystemColors.ButtonHighlight;
			BtnCadastrarHorario.ImageKey = "Calendario-Icone_Branco.png";
			BtnCadastrarHorario.ImageList = imageList1;
			BtnCadastrarHorario.Location = new Point(669, 247);
			BtnCadastrarHorario.Name = "BtnCadastrarHorario";
			BtnCadastrarHorario.Padding = new Padding(1);
			BtnCadastrarHorario.Size = new Size(212, 93);
			BtnCadastrarHorario.TabIndex = 10;
			BtnCadastrarHorario.Text = "Agendar Horário";
			BtnCadastrarHorario.TextImageRelation = TextImageRelation.ImageAboveText;
			BtnCadastrarHorario.UseVisualStyleBackColor = false;
			BtnCadastrarHorario.Click += button10_Click;
			// 
			// LblModoDashboard
			// 
			LblModoDashboard.AutoSize = true;
			LblModoDashboard.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
			LblModoDashboard.Location = new Point(325, 104);
			LblModoDashboard.Name = "LblModoDashboard";
			LblModoDashboard.Size = new Size(493, 41);
			LblModoDashboard.TabIndex = 12;
			LblModoDashboard.Text = "Você está no modo Administrador ";
			// 
			// Menu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1127, 494);
			Controls.Add(LblModoDashboard);
			Controls.Add(BtnPesquisarHorario);
			Controls.Add(BtnCadastrarHorario);
			Controls.Add(BtnPesquisarServico);
			Controls.Add(BtnCadastrarServiço);
			Controls.Add(BtnPesquisarUsuario);
			Controls.Add(BtnCadastrarUsuário);
			Controls.Add(BtnPesquisarCliente);
			Controls.Add(BtnCadastrarCliente);
			Controls.Add(BtnPesquisarFuncionario);
			Controls.Add(BtnCadastrarFuncionario);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(3, 4, 3, 4);
			Name = "Menu";
			Text = "Menu";
			Load += Menu_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private StatusStrip statusStrip1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem aToolStripMenuItem;
		private ToolStripMenuItem novoToolStripMenuItem1;
		private ToolStripMenuItem clienteToolStripMenuItem;
		private ToolStripMenuItem usuárioToolStripMenuItem;
		private ToolStripMenuItem funcionárioToolStripMenuItem;
		private ToolStripMenuItem serviçoToolStripMenuItem;
		private ToolStripMenuItem horárioToolStripMenuItem;
		private ToolStripMenuItem sairToolStripMenuItem;
		private ToolStripMenuItem pesquisarToolStripMenuItem;
		private ToolStripMenuItem usuárioToolStripMenuItem2;
		private ToolStripMenuItem funcionárioToolStripMenuItem2;
		private ToolStripMenuItem clienteToolStripMenuItem2;
		private ToolStripMenuItem serviçoToolStripMenuItem2;
		private ToolStripMenuItem horárioToolStripMenuItem2;
		private Button BtnCadastrarFuncionario;
		private ImageList imageList1;
		private Button BtnPesquisarFuncionario;
		private Button BtnCadastrarCliente;
		private Button BtnPesquisarCliente;
		private Button BtnPesquisarUsuario;
		private Button BtnCadastrarUsuário;
		private Button BtnPesquisarServico;
		private Button BtnCadastrarServiço;
		private Button BtnPesquisarHorario;
		private Button BtnCadastrarHorario;
		private Label LblModoDashboard;
	}
}