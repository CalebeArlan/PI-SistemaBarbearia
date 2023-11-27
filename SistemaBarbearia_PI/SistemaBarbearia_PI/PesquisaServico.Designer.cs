namespace SistemaBarbearia_PI
{
	partial class PesquisaServico
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaServico));
			TxtBusca = new TextBox();
			label4 = new Label();
			dataGridView1 = new DataGridView();
			id = new DataGridViewTextBoxColumn();
			nome = new DataGridViewTextBoxColumn();
			preco = new DataGridViewTextBoxColumn();
			descricao = new DataGridViewTextBoxColumn();
			usuarioBindingSource = new BindingSource(components);
			button1 = new Button();
			imageList1 = new ImageList(components);
			BtnSair = new Button();
			funcionarioBindingSource = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).BeginInit();
			SuspendLayout();
			// 
			// TxtBusca
			// 
			TxtBusca.Location = new Point(11, 89);
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
			label4.Size = new Size(275, 41);
			label4.TabIndex = 8;
			label4.Text = "Pesquisar Serviços";
			// 
			// dataGridView1
			// 
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, preco, descricao });
			dataGridView1.Location = new Point(11, 181);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RightToLeft = RightToLeft.No;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(1180, 445);
			dataGridView1.TabIndex = 9;
			dataGridView1.CellClick += dataGridView1_CellClick;
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
			// preco
			// 
			preco.HeaderText = "Preço";
			preco.MinimumWidth = 6;
			preco.Name = "preco";
			preco.Width = 125;
			// 
			// descricao
			// 
			descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			descricao.HeaderText = "Descrição";
			descricao.MinimumWidth = 6;
			descricao.Name = "descricao";
			descricao.Width = 103;
			// 
			// usuarioBindingSource
			// 
			usuarioBindingSource.DataSource = typeof(Usuario);
			// 
			// button1
			// 
			button1.ImageKey = "LupaPng.png";
			button1.ImageList = imageList1;
			button1.Location = new Point(441, 89);
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
			BtnSair.Location = new Point(535, 88);
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
			// PesquisaServico
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1218, 648);
			Controls.Add(BtnSair);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(label4);
			Controls.Add(TxtBusca);
			Name = "PesquisaServico";
			Text = "Pesquisa de Serviços";
			Load += PesquisaUsuarios_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).EndInit();
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
		private DataGridViewTextBoxColumn id;
		private DataGridViewTextBoxColumn nome;
		private DataGridViewTextBoxColumn preco;
		private DataGridViewTextBoxColumn descricao;
	}
}