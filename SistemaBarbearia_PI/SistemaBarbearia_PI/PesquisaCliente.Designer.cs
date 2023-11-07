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
            BtnSair = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome_usuario = new DataGridViewTextBoxColumn();
            tipo_acesso = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(470, 61);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(75, 23);
            BtnSair.TabIndex = 17;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.LupaPng;
            button1.Location = new Point(388, 62);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(49, 23);
            button1.TabIndex = 16;
            button1.Text = "pesq";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome_usuario, tipo_acesso });
            dataGridView1.Location = new Point(12, 131);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(679, 193);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // nome_usuario
            // 
            nome_usuario.HeaderText = "nome_usuario";
            nome_usuario.MinimumWidth = 6;
            nome_usuario.Name = "nome_usuario";
            nome_usuario.Width = 125;
            // 
            // tipo_acesso
            // 
            tipo_acesso.HeaderText = "tipo_acesso";
            tipo_acesso.MinimumWidth = 6;
            tipo_acesso.Name = "tipo_acesso";
            tipo_acesso.Width = 125;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 18;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(12, 62);
            TxtNome.Margin = new Padding(3, 2, 3, 2);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(371, 23);
            TxtNome.TabIndex = 13;
            TxtNome.Text = "Digite um nome para pesquisar.";
            TxtNome.Click += TxtNome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 19;
            label1.Text = "Pesquisar Cliente";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, novoToolStripMenuItem1, editarToolStripMenuItem, pesquisarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(61, 20);
            aToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // novoToolStripMenuItem1
            // 
            novoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, usuárioToolStripMenuItem, funcionárioToolStripMenuItem, serviçoToolStripMenuItem, horárioToolStripMenuItem });
            novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            novoToolStripMenuItem1.Size = new Size(48, 20);
            novoToolStripMenuItem1.Text = "Novo";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(137, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(137, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(137, 22);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // serviçoToolStripMenuItem
            // 
            serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            serviçoToolStripMenuItem.Size = new Size(137, 22);
            serviçoToolStripMenuItem.Text = "Serviço";
            // 
            // horárioToolStripMenuItem
            // 
            horárioToolStripMenuItem.Name = "horárioToolStripMenuItem";
            horárioToolStripMenuItem.Size = new Size(137, 22);
            horárioToolStripMenuItem.Text = "Horário";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem1, usuárioToolStripMenuItem1, funcionárioToolStripMenuItem1, serviçoToolStripMenuItem1, horárioToolStripMenuItem1 });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // clienteToolStripMenuItem1
            // 
            clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            clienteToolStripMenuItem1.Size = new Size(137, 22);
            clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // usuárioToolStripMenuItem1
            // 
            usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
            usuárioToolStripMenuItem1.Size = new Size(137, 22);
            usuárioToolStripMenuItem1.Text = "Usuário";
            // 
            // funcionárioToolStripMenuItem1
            // 
            funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
            funcionárioToolStripMenuItem1.Size = new Size(137, 22);
            funcionárioToolStripMenuItem1.Text = "Funcionário";
            // 
            // serviçoToolStripMenuItem1
            // 
            serviçoToolStripMenuItem1.Name = "serviçoToolStripMenuItem1";
            serviçoToolStripMenuItem1.Size = new Size(137, 22);
            serviçoToolStripMenuItem1.Text = "Serviço";
            // 
            // horárioToolStripMenuItem1
            // 
            horárioToolStripMenuItem1.Name = "horárioToolStripMenuItem1";
            horárioToolStripMenuItem1.Size = new Size(137, 22);
            horárioToolStripMenuItem1.Text = "Horário";
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem2, funcionárioToolStripMenuItem2, clienteToolStripMenuItem2, serviçoToolStripMenuItem2, vendaToolStripMenuItem, horárioToolStripMenuItem2 });
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(69, 20);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // usuárioToolStripMenuItem2
            // 
            usuárioToolStripMenuItem2.Name = "usuárioToolStripMenuItem2";
            usuárioToolStripMenuItem2.Size = new Size(137, 22);
            usuárioToolStripMenuItem2.Text = "Usuário";
            // 
            // funcionárioToolStripMenuItem2
            // 
            funcionárioToolStripMenuItem2.Name = "funcionárioToolStripMenuItem2";
            funcionárioToolStripMenuItem2.Size = new Size(137, 22);
            funcionárioToolStripMenuItem2.Text = "Funcionário";
            // 
            // clienteToolStripMenuItem2
            // 
            clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            clienteToolStripMenuItem2.Size = new Size(137, 22);
            clienteToolStripMenuItem2.Text = "Cliente";
            // 
            // serviçoToolStripMenuItem2
            // 
            serviçoToolStripMenuItem2.Name = "serviçoToolStripMenuItem2";
            serviçoToolStripMenuItem2.Size = new Size(137, 22);
            serviçoToolStripMenuItem2.Text = "Serviço";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(137, 22);
            vendaToolStripMenuItem.Text = "Venda";
            // 
            // horárioToolStripMenuItem2
            // 
            horárioToolStripMenuItem2.Name = "horárioToolStripMenuItem2";
            horárioToolStripMenuItem2.Size = new Size(137, 22);
            horárioToolStripMenuItem2.Text = "Horário";
            // 
            // PesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 335);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(BtnSair);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(TxtNome);
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
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome_usuario;
        private DataGridViewTextBoxColumn tipo_acesso;
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
    }
}