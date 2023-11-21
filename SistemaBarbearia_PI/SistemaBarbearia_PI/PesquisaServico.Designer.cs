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
            TxtBusca.Location = new Point(10, 67);
            TxtBusca.Margin = new Padding(3, 2, 3, 2);
            TxtBusca.Name = "TxtBusca";
            TxtBusca.Size = new Size(371, 23);
            TxtBusca.TabIndex = 3;
            TxtBusca.Text = "Digite um nome para pesquisar.";
            TxtBusca.Click += TxtNome_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 34);
            label4.Name = "label4";
            label4.Size = new Size(225, 32);
            label4.TabIndex = 8;
            label4.Text = "Pesquisar Serviços";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, preco, descricao });
            dataGridView1.Location = new Point(10, 136);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1032, 334);
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
            descricao.Width = 83;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Usuario);
            // 
            // button1
            // 
            button1.ImageKey = "LupaPng.png";
            button1.ImageList = imageList1;
            button1.Location = new Point(386, 67);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(49, 23);
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
            BtnSair.Location = new Point(468, 66);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(75, 23);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 486);
            Controls.Add(BtnSair);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(TxtBusca);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PesquisaServico";
            Text = "PesquisaFuncionario";
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