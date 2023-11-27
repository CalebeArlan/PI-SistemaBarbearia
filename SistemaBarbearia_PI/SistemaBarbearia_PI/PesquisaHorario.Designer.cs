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
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
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
			Name = "PesquisaHorario";
			Text = "Pesquisar Horários";
			Load += PesquisaUsuarios_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
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