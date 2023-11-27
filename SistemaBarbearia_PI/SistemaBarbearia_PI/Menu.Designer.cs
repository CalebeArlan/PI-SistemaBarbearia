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
			statusStrip1 = new StatusStrip();
			menuStrip1 = new MenuStrip();
			aToolStripMenuItem = new ToolStripMenuItem();
			sairToolStripMenuItem = new ToolStripMenuItem();
			novoToolStripMenuItem1 = new ToolStripMenuItem();
			clienteToolStripMenuItem = new ToolStripMenuItem();
			usuárioToolStripMenuItem = new ToolStripMenuItem();
			funcionárioToolStripMenuItem = new ToolStripMenuItem();
			serviçoToolStripMenuItem = new ToolStripMenuItem();
			horárioToolStripMenuItem = new ToolStripMenuItem();
			pesquisarToolStripMenuItem = new ToolStripMenuItem();
			usuárioToolStripMenuItem2 = new ToolStripMenuItem();
			funcionárioToolStripMenuItem2 = new ToolStripMenuItem();
			clienteToolStripMenuItem2 = new ToolStripMenuItem();
			serviçoToolStripMenuItem2 = new ToolStripMenuItem();
			horárioToolStripMenuItem2 = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(20, 20);
			statusStrip1.Location = new Point(0, 578);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Padding = new Padding(1, 0, 16, 0);
			statusStrip1.Size = new Size(914, 22);
			statusStrip1.TabIndex = 0;
			statusStrip1.Text = "Sistema de Gestão e Agendamento de Barbearia  v4.1";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, novoToolStripMenuItem1, pesquisarToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(7, 3, 0, 3);
			menuStrip1.Size = new Size(914, 30);
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
			sairToolStripMenuItem.Size = new Size(117, 26);
			sairToolStripMenuItem.Text = "Sair";
			sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
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
			clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click_1;
			// 
			// usuárioToolStripMenuItem
			// 
			usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
			usuárioToolStripMenuItem.Size = new Size(169, 26);
			usuárioToolStripMenuItem.Text = "Usuário";
			usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
			// 
			// funcionárioToolStripMenuItem
			// 
			funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
			funcionárioToolStripMenuItem.Size = new Size(169, 26);
			funcionárioToolStripMenuItem.Text = "Funcionário";
			funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
			// 
			// serviçoToolStripMenuItem
			// 
			serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
			serviçoToolStripMenuItem.Size = new Size(169, 26);
			serviçoToolStripMenuItem.Text = "Serviço";
			serviçoToolStripMenuItem.Click += serviçoToolStripMenuItem_Click;
			// 
			// horárioToolStripMenuItem
			// 
			horárioToolStripMenuItem.Name = "horárioToolStripMenuItem";
			horárioToolStripMenuItem.Size = new Size(169, 26);
			horárioToolStripMenuItem.Text = "Horário";
			horárioToolStripMenuItem.Click += horárioToolStripMenuItem_Click;
			// 
			// pesquisarToolStripMenuItem
			// 
			pesquisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem2, funcionárioToolStripMenuItem2, clienteToolStripMenuItem2, serviçoToolStripMenuItem2, horárioToolStripMenuItem2 });
			pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
			pesquisarToolStripMenuItem.Size = new Size(84, 24);
			pesquisarToolStripMenuItem.Text = "Pesquisar";
			// 
			// usuárioToolStripMenuItem2
			// 
			usuárioToolStripMenuItem2.Name = "usuárioToolStripMenuItem2";
			usuárioToolStripMenuItem2.Size = new Size(224, 26);
			usuárioToolStripMenuItem2.Text = "Usuário";
			usuárioToolStripMenuItem2.Click += usuárioToolStripMenuItem2_Click;
			// 
			// funcionárioToolStripMenuItem2
			// 
			funcionárioToolStripMenuItem2.Name = "funcionárioToolStripMenuItem2";
			funcionárioToolStripMenuItem2.Size = new Size(224, 26);
			funcionárioToolStripMenuItem2.Text = "Funcionário";
			funcionárioToolStripMenuItem2.Click += funcionárioToolStripMenuItem2_Click;
			// 
			// clienteToolStripMenuItem2
			// 
			clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
			clienteToolStripMenuItem2.Size = new Size(224, 26);
			clienteToolStripMenuItem2.Text = "Cliente";
			clienteToolStripMenuItem2.Click += clienteToolStripMenuItem2_Click_1;
			// 
			// serviçoToolStripMenuItem2
			// 
			serviçoToolStripMenuItem2.Name = "serviçoToolStripMenuItem2";
			serviçoToolStripMenuItem2.Size = new Size(224, 26);
			serviçoToolStripMenuItem2.Text = "Serviço";
			serviçoToolStripMenuItem2.Click += serviçoToolStripMenuItem2_Click;
			// 
			// horárioToolStripMenuItem2
			// 
			horárioToolStripMenuItem2.Name = "horárioToolStripMenuItem2";
			horárioToolStripMenuItem2.Size = new Size(224, 26);
			horárioToolStripMenuItem2.Text = "Horário";
			horárioToolStripMenuItem2.Click += horárioToolStripMenuItem2_Click;
			// 
			// Menu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
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
	}
}