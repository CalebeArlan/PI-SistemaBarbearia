using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBarbearia_PI
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();

		}
		private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmCadastroUsuario form = new FrmCadastroUsuario();
			form.Show();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmLoginUsuario login = (FrmLoginUsuario)Application.OpenForms["FrmLoginUsuario"];
			login.Visible = true;
			this.Close();
		}

		public void usuárioToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			PesquisaUsuarios pesquisaUsuarios = new PesquisaUsuarios();
			pesquisaUsuarios.Show();
		}

		private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastroFuncionario cadastrofuncionarios = new CadastroFuncionario();
			cadastrofuncionarios.Show();
		}

		private void funcionárioToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			PesquisaFuncionario pesquisafuncionario = new PesquisaFuncionario();
			pesquisafuncionario.Show();
		}

		private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastroServico cadastroservico = new CadastroServico();
			cadastroservico.Show();
		}

		private void serviçoToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			PesquisaServico pesquisaservico = new PesquisaServico();
			pesquisaservico.Show();
		}

		private void horárioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastroHorario cadastrohorario = new CadastroHorario();
			cadastrohorario.Show();
		}

		private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			PesquisaCliente pesquisacliente = new PesquisaCliente();
			pesquisacliente.Show();
		}

		private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastraCliente cadastraCliente = new CadastraCliente();
			cadastraCliente.Show();
		}

		private void clienteToolStripMenuItem2_Click_1(object sender, EventArgs e)
		{
			PesquisaCliente pesquisaCliente = new PesquisaCliente();
			pesquisaCliente.Show();
		}

		private void horárioToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			PesquisaHorario pesquisaHorario = new PesquisaHorario();
			pesquisaHorario.Show();
		}

		private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			CadastraCliente cadastraCliente = new CadastraCliente();
			cadastraCliente.Show();
		}
	}
}


