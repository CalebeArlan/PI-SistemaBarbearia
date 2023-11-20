namespace SistemaBarbearia_PI
{
	partial class PesquisaHorario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaHorario));
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
			TxtBusca = new TextBox();
			label4 = new Label();
			dataGridView1 = new DataGridView();
			id = new DataGridViewTextBoxColumn();
			nome_cliente = new DataGridViewTextBoxColumn();
			nome_servico = new DataGridViewTextBoxColumn();
			hora = new DataGridViewTextBoxColumn();
			data_horario = new DataGridViewTextBoxColumn();
			usuarioBindingSource = new BindingSource(components);
			button1 = new Button();
			imageList1 = new ImageList(components);
			BtnSair = new Button();
			funcionarioBindingSource = new BindingSource(components);
			groupBox1 = new GroupBox();
			RdbData = new RadioButton();
			RdBNome = new RadioButton();
			DtpData = new DateTimePicker();
			BtnPesquisaTodos = new Button();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, novoToolStripMenuItem1, editarToolStripMenuItem, pesquisarToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(7, 3, 0, 3);
			menuStrip1.Size = new Size(1218, 30);
			menuStrip1.TabIndex = 2;
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
			// TxtBusca
			// 
			TxtBusca.Location = new Point(11, 88);
			TxtBusca.Name = "TxtBusca";
			TxtBusca.Size = new Size(423, 27);
			TxtBusca.TabIndex = 3;
			TxtBusca.Text = "Digite um nome para pesquisar.";
			TxtBusca.Click += TxtNome_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(11, 45);
			label4.Name = "label4";
			label4.Size = new Size(280, 41);
			label4.TabIndex = 8;
			label4.Text = "Pesquisar Horários";
			// 
			// dataGridView1
			// 
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome_cliente, nome_servico, hora, data_horario });
			dataGridView1.Location = new Point(11, 181);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RightToLeft = RightToLeft.No;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1180, 445);
			dataGridView1.TabIndex = 9;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// id
			// 
			id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			id.HeaderText = "id";
			id.MinimumWidth = 6;
			id.Name = "id";
			// 
			// nome_cliente
			// 
			nome_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			nome_cliente.HeaderText = "Cliente";
			nome_cliente.MinimumWidth = 6;
			nome_cliente.Name = "nome_cliente";
			// 
			// nome_servico
			// 
			nome_servico.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			nome_servico.HeaderText = "Serviço";
			nome_servico.MinimumWidth = 6;
			nome_servico.Name = "nome_servico";
			// 
			// hora
			// 
			hora.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			hora.HeaderText = "Horário";
			hora.MinimumWidth = 6;
			hora.Name = "hora";
			// 
			// data_horario
			// 
			data_horario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			data_horario.HeaderText = "Data";
			data_horario.MinimumWidth = 6;
			data_horario.Name = "data_horario";
			// 
			// usuarioBindingSource
			// 
			usuarioBindingSource.DataSource = typeof(Usuario);
			// 
			// button1
			// 
			button1.ImageKey = "LupaPng.png";
			button1.ImageList = imageList1;
			button1.Location = new Point(441, 86);
			button1.Name = "button1";
			button1.Size = new Size(56, 31);
			button1.TabIndex = 10;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth8Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName(0, "LupaPng.png");
			// 
			// BtnSair
			// 
			BtnSair.Location = new Point(503, 86);
			BtnSair.Margin = new Padding(3, 4, 3, 4);
			BtnSair.Name = "BtnSair";
			BtnSair.Size = new Size(86, 31);
			BtnSair.TabIndex = 11;
			BtnSair.Text = "Sair";
			BtnSair.UseVisualStyleBackColor = true;
			BtnSair.Click += BtnSair_Click;
			// 
			// funcionarioBindingSource
			// 
			funcionarioBindingSource.DataSource = typeof(Funcionario);
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(RdbData);
			groupBox1.Controls.Add(RdBNome);
			groupBox1.Location = new Point(746, 45);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(250, 125);
			groupBox1.TabIndex = 13;
			groupBox1.TabStop = false;
			groupBox1.Text = "Pesquisar Por";
			// 
			// RdbData
			// 
			RdbData.AutoSize = true;
			RdbData.Location = new Point(21, 73);
			RdbData.Name = "RdbData";
			RdbData.Size = new Size(62, 24);
			RdbData.TabIndex = 1;
			RdbData.Text = "Data";
			RdbData.UseVisualStyleBackColor = true;
			RdbData.CheckedChanged += RdbCPF_CheckedChanged;
			// 
			// RdBNome
			// 
			RdBNome.AutoSize = true;
			RdBNome.Checked = true;
			RdBNome.Location = new Point(21, 43);
			RdBNome.Name = "RdBNome";
			RdBNome.Size = new Size(143, 24);
			RdBNome.TabIndex = 0;
			RdBNome.TabStop = true;
			RdBNome.Text = "Nome do Cliente";
			RdBNome.UseVisualStyleBackColor = true;
			RdBNome.CheckedChanged += RdBNome_CheckedChanged;
			// 
			// DtpData
			// 
			DtpData.Format = DateTimePickerFormat.Short;
			DtpData.Location = new Point(11, 88);
			DtpData.Name = "DtpData";
			DtpData.Size = new Size(423, 27);
			DtpData.TabIndex = 14;
			DtpData.Visible = false;
			// 
			// BtnPesquisaTodos
			// 
			BtnPesquisaTodos.Location = new Point(12, 139);
			BtnPesquisaTodos.Margin = new Padding(3, 4, 3, 4);
			BtnPesquisaTodos.Name = "BtnPesquisaTodos";
			BtnPesquisaTodos.Size = new Size(142, 31);
			BtnPesquisaTodos.TabIndex = 15;
			BtnPesquisaTodos.Text = "Pesquisar Todos";
			BtnPesquisaTodos.UseVisualStyleBackColor = true;
			BtnPesquisaTodos.Click += BtnPesquisaTodos_Click;
			// 
			// PesquisaHorario
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1218, 648);
			Controls.Add(BtnPesquisaTodos);
			Controls.Add(DtpData);
			Controls.Add(groupBox1);
			Controls.Add(BtnSair);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(label4);
			Controls.Add(TxtBusca);
			Controls.Add(menuStrip1);
			Name = "PesquisaHorario";
			Text = "PesquisaFuncionario";
			Load += PesquisaUsuarios_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

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
		private TextBox TxtBusca;
		private Label label4;
		private BindingSource usuarioBindingSource;
		private Button button1;
		private ImageList imageList1;
		private Button BtnSair;
		public DataGridView dataGridView1;
		private BindingSource funcionarioBindingSource;
		private GroupBox groupBox1;
		private RadioButton RdbData;
		private RadioButton RdBNome;
		private DataGridViewTextBoxColumn id;
		private DataGridViewTextBoxColumn nome_cliente;
		private DataGridViewTextBoxColumn nome_servico;
		private DataGridViewTextBoxColumn hora;
		private DataGridViewTextBoxColumn data_horario;
		private DateTimePicker DtpData;
		private Button BtnPesquisaTodos;
	}
}