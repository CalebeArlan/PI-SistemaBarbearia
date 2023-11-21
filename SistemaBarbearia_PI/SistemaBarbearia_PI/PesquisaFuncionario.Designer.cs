namespace SistemaBarbearia_PI
{
    partial class PesquisaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaFuncionario));
            TxtBusca = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            datanasc = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            rg = new DataGridViewTextBoxColumn();
            endereco = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            cargo = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            usuarioBindingSource = new BindingSource(components);
            button1 = new Button();
            imageList1 = new ImageList(components);
            BtnSair = new Button();
            funcionarioBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            RdbCPF = new RadioButton();
            RdBNome = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).BeginInit();
            groupBox1.SuspendLayout();
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
            label4.Size = new Size(277, 32);
            label4.TabIndex = 8;
            label4.Text = "Pesquisar Funcionários";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, Telefone, datanasc, cpf, rg, endereco, email, cargo, Salario });
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
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 6;
            Telefone.Name = "Telefone";
            Telefone.Width = 125;
            // 
            // datanasc
            // 
            datanasc.HeaderText = "Data de Nascimento";
            datanasc.MaxInputLength = 11;
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
            // endereco
            // 
            endereco.HeaderText = "Endereço";
            endereco.MinimumWidth = 6;
            endereco.Name = "endereco";
            endereco.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 125;
            // 
            // cargo
            // 
            cargo.HeaderText = "Cargo";
            cargo.MinimumWidth = 6;
            cargo.Name = "cargo";
            cargo.Width = 125;
            // 
            // Salario
            // 
            Salario.HeaderText = "Salário";
            Salario.MinimumWidth = 6;
            Salario.Name = "Salario";
            Salario.Width = 125;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(RdbCPF);
            groupBox1.Controls.Add(RdBNome);
            groupBox1.Location = new Point(677, 25);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(219, 94);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisar Por";
            // 
            // RdbCPF
            // 
            RdbCPF.AutoSize = true;
            RdbCPF.Location = new Point(18, 55);
            RdbCPF.Margin = new Padding(3, 2, 3, 2);
            RdbCPF.Name = "RdbCPF";
            RdbCPF.Size = new Size(46, 19);
            RdbCPF.TabIndex = 1;
            RdbCPF.Text = "CPF";
            RdbCPF.UseVisualStyleBackColor = true;
            // 
            // RdBNome
            // 
            RdBNome.AutoSize = true;
            RdBNome.Checked = true;
            RdBNome.Location = new Point(18, 32);
            RdBNome.Margin = new Padding(3, 2, 3, 2);
            RdBNome.Name = "RdBNome";
            RdBNome.Size = new Size(58, 19);
            RdBNome.TabIndex = 0;
            RdBNome.TabStop = true;
            RdBNome.Text = "Nome";
            RdBNome.UseVisualStyleBackColor = true;
            // 
            // PesquisaFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 486);
            Controls.Add(groupBox1);
            Controls.Add(BtnSair);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(TxtBusca);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PesquisaFuncionario";
            Text = "PesquisaFuncionario";
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
        private RadioButton RdbCPF;
        private RadioButton RdBNome;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn datanasc;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn rg;
        private DataGridViewTextBoxColumn endereco;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn cargo;
        private DataGridViewTextBoxColumn Salario;
    }
}