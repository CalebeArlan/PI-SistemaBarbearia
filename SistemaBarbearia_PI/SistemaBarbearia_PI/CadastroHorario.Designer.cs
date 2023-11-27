namespace SistemaBarbearia_PI
{
	partial class CadastroHorario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroHorario));
			button1 = new Button();
			label4 = new Label();
			BtnCadastrar = new Button();
			LblData = new Label();
			label5 = new Label();
			DtpData = new DateTimePicker();
			DtpHorario = new DateTimePicker();
			button2 = new Button();
			imageList1 = new ImageList(components);
			dataGridView1 = new DataGridView();
			id = new DataGridViewTextBoxColumn();
			nome = new DataGridViewTextBoxColumn();
			telefone = new DataGridViewTextBoxColumn();
			email = new DataGridViewTextBoxColumn();
			datanasc = new DataGridViewTextBoxColumn();
			cpf = new DataGridViewTextBoxColumn();
			rg = new DataGridViewTextBoxColumn();
			TxtNome = new TextBox();
			GrpSelecionarCliente = new GroupBox();
			groupBox1 = new GroupBox();
			button3 = new Button();
			dataGridView2 = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			preco = new DataGridViewTextBoxColumn();
			descricao = new DataGridViewTextBoxColumn();
			TxtPesquisaServico = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			GrpSelecionarCliente.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(29, 430);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(86, 31);
			button1.TabIndex = 11;
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
			label4.Size = new Size(353, 41);
			label4.TabIndex = 17;
			label4.Text = "Cadastrar Novo Horário";
			// 
			// BtnCadastrar
			// 
			BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
			BtnCadastrar.Location = new Point(274, 418);
			BtnCadastrar.Name = "BtnCadastrar";
			BtnCadastrar.Size = new Size(64, 55);
			BtnCadastrar.TabIndex = 10;
			BtnCadastrar.UseVisualStyleBackColor = true;
			BtnCadastrar.Click += BtnCadastrar_Click;
			// 
			// LblData
			// 
			LblData.AutoSize = true;
			LblData.Location = new Point(24, 97);
			LblData.Name = "LblData";
			LblData.Size = new Size(44, 20);
			LblData.TabIndex = 11;
			LblData.Text = "Data:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(251, 97);
			label5.Name = "label5";
			label5.Size = new Size(63, 20);
			label5.TabIndex = 31;
			label5.Text = "Horário:";
			// 
			// DtpData
			// 
			DtpData.CustomFormat = "";
			DtpData.Format = DateTimePickerFormat.Short;
			DtpData.Location = new Point(74, 92);
			DtpData.Margin = new Padding(3, 4, 3, 4);
			DtpData.Name = "DtpData";
			DtpData.Size = new Size(151, 27);
			DtpData.TabIndex = 32;
			// 
			// DtpHorario
			// 
			DtpHorario.CustomFormat = "HH:mm";
			DtpHorario.Format = DateTimePickerFormat.Custom;
			DtpHorario.Location = new Point(314, 92);
			DtpHorario.Margin = new Padding(3, 4, 3, 4);
			DtpHorario.Name = "DtpHorario";
			DtpHorario.ShowUpDown = true;
			DtpHorario.Size = new Size(117, 27);
			DtpHorario.TabIndex = 33;
			// 
			// button2
			// 
			button2.ImageKey = "LupaPng.png";
			button2.ImageList = imageList1;
			button2.Location = new Point(435, 27);
			button2.Name = "button2";
			button2.Size = new Size(56, 31);
			button2.TabIndex = 36;
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth8Bit;
			imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			imageList1.TransparentColor = Color.Transparent;
			imageList1.Images.SetKeyName(0, "LupaPng.png");
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, telefone, email, datanasc, cpf, rg });
			dataGridView1.Location = new Point(6, 64);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(502, 170);
			dataGridView1.TabIndex = 35;
			// 
			// id
			// 
			id.HeaderText = "id";
			id.MinimumWidth = 6;
			id.Name = "id";
			id.ReadOnly = true;
			id.Width = 125;
			// 
			// nome
			// 
			nome.HeaderText = "Nome";
			nome.MinimumWidth = 6;
			nome.Name = "nome";
			nome.ReadOnly = true;
			nome.Width = 125;
			// 
			// telefone
			// 
			telefone.HeaderText = "Telefone";
			telefone.MinimumWidth = 6;
			telefone.Name = "telefone";
			telefone.ReadOnly = true;
			telefone.Width = 125;
			// 
			// email
			// 
			email.HeaderText = "Email";
			email.MinimumWidth = 6;
			email.Name = "email";
			email.ReadOnly = true;
			email.Width = 125;
			// 
			// datanasc
			// 
			datanasc.HeaderText = "Data de Nascimento";
			datanasc.MinimumWidth = 6;
			datanasc.Name = "datanasc";
			datanasc.ReadOnly = true;
			datanasc.Width = 125;
			// 
			// cpf
			// 
			cpf.HeaderText = "CPF";
			cpf.MinimumWidth = 6;
			cpf.Name = "cpf";
			cpf.ReadOnly = true;
			cpf.Width = 125;
			// 
			// rg
			// 
			rg.HeaderText = "RG";
			rg.MinimumWidth = 6;
			rg.Name = "rg";
			rg.ReadOnly = true;
			rg.Width = 125;
			// 
			// TxtNome
			// 
			TxtNome.Location = new Point(6, 27);
			TxtNome.Name = "TxtNome";
			TxtNome.Size = new Size(423, 27);
			TxtNome.TabIndex = 34;
			TxtNome.Text = "Digite um nome para pesquisar.";
			TxtNome.Click += TxtNome_Click;
			// 
			// GrpSelecionarCliente
			// 
			GrpSelecionarCliente.Controls.Add(button2);
			GrpSelecionarCliente.Controls.Add(dataGridView1);
			GrpSelecionarCliente.Controls.Add(TxtNome);
			GrpSelecionarCliente.Location = new Point(24, 167);
			GrpSelecionarCliente.Name = "GrpSelecionarCliente";
			GrpSelecionarCliente.Size = new Size(514, 245);
			GrpSelecionarCliente.TabIndex = 37;
			GrpSelecionarCliente.TabStop = false;
			GrpSelecionarCliente.Text = "Selecionar Cliente";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button3);
			groupBox1.Controls.Add(dataGridView2);
			groupBox1.Controls.Add(TxtPesquisaServico);
			groupBox1.Location = new Point(545, 167);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(514, 245);
			groupBox1.TabIndex = 38;
			groupBox1.TabStop = false;
			groupBox1.Text = "Selecionar Serviço";
			// 
			// button3
			// 
			button3.ImageKey = "LupaPng.png";
			button3.ImageList = imageList1;
			button3.Location = new Point(435, 27);
			button3.Name = "button3";
			button3.Size = new Size(56, 31);
			button3.TabIndex = 36;
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, preco, descricao });
			dataGridView2.Location = new Point(6, 64);
			dataGridView2.MultiSelect = false;
			dataGridView2.Name = "dataGridView2";
			dataGridView2.ReadOnly = true;
			dataGridView2.RowHeadersWidth = 51;
			dataGridView2.RowTemplate.Height = 29;
			dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView2.Size = new Size(502, 170);
			dataGridView2.TabIndex = 35;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "id";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Width = 125;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.HeaderText = "Nome";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			dataGridViewTextBoxColumn2.Width = 125;
			// 
			// preco
			// 
			preco.HeaderText = "Preço";
			preco.MinimumWidth = 6;
			preco.Name = "preco";
			preco.ReadOnly = true;
			preco.Width = 125;
			// 
			// descricao
			// 
			descricao.HeaderText = "Descrição";
			descricao.MinimumWidth = 6;
			descricao.Name = "descricao";
			descricao.ReadOnly = true;
			descricao.Width = 125;
			// 
			// TxtPesquisaServico
			// 
			TxtPesquisaServico.Location = new Point(6, 27);
			TxtPesquisaServico.Name = "TxtPesquisaServico";
			TxtPesquisaServico.Size = new Size(423, 27);
			TxtPesquisaServico.TabIndex = 34;
			TxtPesquisaServico.Text = "Digite um nome para pesquisar.";
			// 
			// CadastroHorario
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1071, 520);
			Controls.Add(groupBox1);
			Controls.Add(DtpHorario);
			Controls.Add(DtpData);
			Controls.Add(label5);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(BtnCadastrar);
			Controls.Add(LblData);
			Controls.Add(GrpSelecionarCliente);
			Name = "CadastroHorario";
			Text = "Cadastrar Novo Horário";
			Load += CadastroHorario_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			GrpSelecionarCliente.ResumeLayout(false);
			GrpSelecionarCliente.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label4;
		private Button BtnCadastrar;
		private Label LblData;
		private Label label5;
		private DateTimePicker DtpData;
		private DateTimePicker DtpHorario;
		private Button button2;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn id;
		private DataGridViewTextBoxColumn nome;
		private DataGridViewTextBoxColumn telefone;
		private DataGridViewTextBoxColumn email;
		private DataGridViewTextBoxColumn datanasc;
		private DataGridViewTextBoxColumn cpf;
		private DataGridViewTextBoxColumn rg;
		private TextBox TxtNome;
		private ImageList imageList1;
		private GroupBox GrpSelecionarCliente;
		private GroupBox groupBox1;
		private Button button3;
		private DataGridView dataGridView2;
		private TextBox TxtPesquisaServico;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn preco;
		private DataGridViewTextBoxColumn descricao;
	}
}