namespace SistemaBarbearia_PI
{
	partial class PesquisaCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaCliente));
			BtnSair = new Button();
			button1 = new Button();
			dataGridView1 = new DataGridView();
			id = new DataGridViewTextBoxColumn();
			nome = new DataGridViewTextBoxColumn();
			telefone = new DataGridViewTextBoxColumn();
			email = new DataGridViewTextBoxColumn();
			datanasc = new DataGridViewTextBoxColumn();
			cpf = new DataGridViewTextBoxColumn();
			rg = new DataGridViewTextBoxColumn();
			label4 = new Label();
			TxtNome = new TextBox();
			label1 = new Label();
			menuStrip1 = new MenuStrip();
			aToolStripMenuItem = new ToolStripMenuItem();
			sairToolStripMenuItem = new ToolStripMenuItem();
			novoToolStripMenuItem1 = new ToolStripMenuItem();
			clienteToolStripMenuItem = new ToolStripMenuItem();
			usuárioToolStripMenuItem = new ToolStripMenuItem();
			funcionárioToolStripMenuItem = new ToolStripMenuItem();
			serviçoToolStripMenuItem = new ToolStripMenuItem();
			horárioToolStripMenuItem = new ToolStripMenuItem();
			editarToolStripMenuItem = new ToolStripMenuItem();
			clienteToolStripMenuItem1 = new ToolStripMenuItem();
			usuárioToolStripMenuItem1 = new ToolStripMenuItem();
			funcionárioToolStripMenuItem1 = new ToolStripMenuItem();
			serviçoToolStripMenuItem1 = new ToolStripMenuItem();
			horárioToolStripMenuItem1 = new ToolStripMenuItem();
			pesquisarToolStripMenuItem = new ToolStripMenuItem();
			usuárioToolStripMenuItem2 = new ToolStripMenuItem();
			funcionárioToolStripMenuItem2 = new ToolStripMenuItem();
			clienteToolStripMenuItem2 = new ToolStripMenuItem();
			serviçoToolStripMenuItem2 = new ToolStripMenuItem();
			vendaToolStripMenuItem = new ToolStripMenuItem();
			horárioToolStripMenuItem2 = new ToolStripMenuItem();
			imageList1 = new ImageList(components);
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// BtnSair
			// 
			BtnSair.Location = new Point(537, 81);
			BtnSair.Margin = new Padding(3, 4, 3, 4);
			BtnSair.Name = "BtnSair";
			BtnSair.Size = new Size(86, 31);
			BtnSair.TabIndex = 17;
			BtnSair.Text = "Sair";
			BtnSair.UseVisualStyleBackColor = true;
			BtnSair.Click += BtnSair_Click;
			// 
			// button1
			// 
			button1.ImageKey = "LupaPng.png";
			button1.ImageList = imageList1;
			button1.Location = new Point(443, 83);
			button1.Name = "button1";
			button1.Size = new Size(56, 31);
			button1.TabIndex = 16;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, telefone, email, datanasc, cpf, rg });
			dataGridView1.Location = new Point(14, 175);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(776, 257);
			dataGridView1.TabIndex = 15;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// id
			// 
			id.HeaderText = "id";
			id.MinimumWidth = 6;
			id.Name = "id";
			id.Width = 125;
			// 
			// nome
			// 
			nome.HeaderText = "Nome";
			nome.MinimumWidth = 6;
			nome.Name = "nome";
			nome.Width = 125;
			// 
			// telefone
			// 
			telefone.HeaderText = "Telefone";
			telefone.MinimumWidth = 6;
			telefone.Name = "telefone";
			telefone.Width = 125;
			// 
			// email
			// 
			email.HeaderText = "Email";
			email.MinimumWidth = 6;
			email.Name = "email";
			email.Width = 125;
			// 
			// datanasc
			// 
			datanasc.HeaderText = "Data de Nascimento";
			datanasc.MinimumWidth = 6;
			datanasc.Name = "datanasc";
			datanasc.Width = 125;
			// 
			// cpf
			// 
			cpf.HeaderText = "CPF";
			cpf.MinimumWidth = 6;
			cpf.Name = "cpf";
			cpf.Width = 125;
			// 
			// rg
			// 
			rg.HeaderText = "RG";
			rg.MinimumWidth = 6;
			rg.Name = "rg";
			rg.Width = 125;
			// 
			// label4
			// 
			label4.Location = new Point(0, 0);
			label4.Name = "label4";
			label4.Size = new Size(114, 31);
			label4.TabIndex = 18;
			// 
			// TxtNome
			// 
			TxtNome.Location = new Point(14, 83);
			TxtNome.Name = "TxtNome";
			TxtNome.Size = new Size(423, 27);
			TxtNome.TabIndex = 13;
			TxtNome.Text = "Digite um nome para pesquisar.";
			TxtNome.Click += TxtNome_Click;
			TxtNome.TextChanged += TxtNome_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(14, 37);
			label1.Name = "label1";
			label1.Size = new Size(258, 41);
			label1.TabIndex = 19;
			label1.Text = "Pesquisar Cliente";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, novoToolStripMenuItem1, editarToolStripMenuItem, pesquisarToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(7, 3, 0, 3);
			menuStrip1.Size = new Size(914, 30);
			menuStrip1.TabIndex = 20;
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
			sairToolStripMenuItem.Size = new Size(117, 26);
			sairToolStripMenuItem.Text = "Sair";
			// 
			// novoToolStripMenuItem1
			// 
			novoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, usuárioToolStripMenuItem, funcionárioToolStripMenuItem, serviçoToolStripMenuItem, horárioToolStripMenuItem });
			novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
			novoToolStripMenuItem1.Size = new Size(59, 24);
			novoToolStripMenuItem1.Text = "Novo";
			// 
			// clienteToolStripMenuItem
			// 
			clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
			clienteToolStripMenuItem.Size = new Size(169, 26);
			clienteToolStripMenuItem.Text = "Cliente";
			// 
			// usuárioToolStripMenuItem
			// 
			usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
			usuárioToolStripMenuItem.Size = new Size(169, 26);
			usuárioToolStripMenuItem.Text = "Usuário";
			// 
			// funcionárioToolStripMenuItem
			// 
			funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
			funcionárioToolStripMenuItem.Size = new Size(169, 26);
			funcionárioToolStripMenuItem.Text = "Funcionário";
			// 
			// serviçoToolStripMenuItem
			// 
			serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
			serviçoToolStripMenuItem.Size = new Size(169, 26);
			serviçoToolStripMenuItem.Text = "Serviço";
			// 
			// horárioToolStripMenuItem
			// 
			horárioToolStripMenuItem.Name = "horárioToolStripMenuItem";
			horárioToolStripMenuItem.Size = new Size(169, 26);
			horárioToolStripMenuItem.Text = "Horário";
			// 
			// editarToolStripMenuItem
			// 
			editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem1, usuárioToolStripMenuItem1, funcionárioToolStripMenuItem1, serviçoToolStripMenuItem1, horárioToolStripMenuItem1 });
			editarToolStripMenuItem.Name = "editarToolStripMenuItem";
			editarToolStripMenuItem.Size = new Size(62, 24);
			editarToolStripMenuItem.Text = "Editar";
			// 
			// clienteToolStripMenuItem1
			// 
			clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
			clienteToolStripMenuItem1.Size = new Size(169, 26);
			clienteToolStripMenuItem1.Text = "Cliente";
			// 
			// usuárioToolStripMenuItem1
			// 
			usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
			usuárioToolStripMenuItem1.Size = new Size(169, 26);
			usuárioToolStripMenuItem1.Text = "Usuário";
			// 
			// funcionárioToolStripMenuItem1
			// 
			funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
			funcionárioToolStripMenuItem1.Size = new Size(169, 26);
			funcionárioToolStripMenuItem1.Text = "Funcionário";
			// 
			// serviçoToolStripMenuItem1
			// 
			serviçoToolStripMenuItem1.Name = "serviçoToolStripMenuItem1";
			serviçoToolStripMenuItem1.Size = new Size(169, 26);
			serviçoToolStripMenuItem1.Text = "Serviço";
			// 
			// horárioToolStripMenuItem1
			// 
			horárioToolStripMenuItem1.Name = "horárioToolStripMenuItem1";
			horárioToolStripMenuItem1.Size = new Size(169, 26);
			horárioToolStripMenuItem1.Text = "Horário";
			// 
			// pesquisarToolStripMenuItem
			// 
			pesquisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem2, funcionárioToolStripMenuItem2, clienteToolStripMenuItem2, serviçoToolStripMenuItem2, vendaToolStripMenuItem, horárioToolStripMenuItem2 });
			pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
			pesquisarToolStripMenuItem.Size = new Size(84, 24);
			pesquisarToolStripMenuItem.Text = "Pesquisar";
			// 
			// usuárioToolStripMenuItem2
			// 
			usuárioToolStripMenuItem2.Name = "usuárioToolStripMenuItem2";
			usuárioToolStripMenuItem2.Size = new Size(169, 26);
			usuárioToolStripMenuItem2.Text = "Usuário";
			// 
			// funcionárioToolStripMenuItem2
			// 
			funcionárioToolStripMenuItem2.Name = "funcionárioToolStripMenuItem2";
			funcionárioToolStripMenuItem2.Size = new Size(169, 26);
			funcionárioToolStripMenuItem2.Text = "Funcionário";
			// 
			// clienteToolStripMenuItem2
			// 
			clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
			clienteToolStripMenuItem2.Size = new Size(169, 26);
			clienteToolStripMenuItem2.Text = "Cliente";
			// 
			// serviçoToolStripMenuItem2
			// 
			serviçoToolStripMenuItem2.Name = "serviçoToolStripMenuItem2";
			serviçoToolStripMenuItem2.Size = new Size(169, 26);
			serviçoToolStripMenuItem2.Text = "Serviço";
			// 
			// vendaToolStripMenuItem
			// 
			vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
			vendaToolStripMenuItem.Size = new Size(169, 26);
			vendaToolStripMenuItem.Text = "Venda";
			// 
			// horárioToolStripMenuItem2
			// 
			horárioToolStripMenuItem2.Name = "horárioToolStripMenuItem2";
			horárioToolStripMenuItem2.Size = new Size(169, 26);
			horárioToolStripMenuItem2.Text = "Horário";
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth8Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName(0, "LupaPng.png");
			// 
			// PesquisaCliente
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 447);
			Controls.Add(menuStrip1);
			Controls.Add(label1);
			Controls.Add(BtnSair);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(label4);
			Controls.Add(TxtNome);
			Margin = new Padding(3, 4, 3, 4);
			Name = "PesquisaCliente";
			Text = "PesquisaCliente";
			Load += PesquisaCliente_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button BtnSair;
		private Button button1;
		private DataGridView dataGridView1;
		private Label label4;
		private TextBox TxtNome;
		private Label label1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem aToolStripMenuItem;
		private ToolStripMenuItem sairToolStripMenuItem;
		private ToolStripMenuItem novoToolStripMenuItem1;
		private ToolStripMenuItem clienteToolStripMenuItem;
		private ToolStripMenuItem usuárioToolStripMenuItem;
		private ToolStripMenuItem funcionárioToolStripMenuItem;
		private ToolStripMenuItem serviçoToolStripMenuItem;
		private ToolStripMenuItem horárioToolStripMenuItem;
		private ToolStripMenuItem editarToolStripMenuItem;
		private ToolStripMenuItem clienteToolStripMenuItem1;
		private ToolStripMenuItem usuárioToolStripMenuItem1;
		private ToolStripMenuItem funcionárioToolStripMenuItem1;
		private ToolStripMenuItem serviçoToolStripMenuItem1;
		private ToolStripMenuItem horárioToolStripMenuItem1;
		private ToolStripMenuItem pesquisarToolStripMenuItem;
		private ToolStripMenuItem usuárioToolStripMenuItem2;
		private ToolStripMenuItem funcionárioToolStripMenuItem2;
		private ToolStripMenuItem clienteToolStripMenuItem2;
		private ToolStripMenuItem serviçoToolStripMenuItem2;
		private ToolStripMenuItem vendaToolStripMenuItem;
		private ToolStripMenuItem horárioToolStripMenuItem2;
		private DataGridViewTextBoxColumn id;
		private DataGridViewTextBoxColumn nome;
		private DataGridViewTextBoxColumn telefone;
		private DataGridViewTextBoxColumn email;
		private DataGridViewTextBoxColumn datanasc;
		private DataGridViewTextBoxColumn cpf;
		private DataGridViewTextBoxColumn rg;
		private ImageList imageList1;
	}
}