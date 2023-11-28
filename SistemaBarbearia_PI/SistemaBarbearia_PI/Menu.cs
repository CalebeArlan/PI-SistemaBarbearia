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

		private void Menu_Load(object sender, EventArgs e)
		{
			if (FrmLoginUsuario.TipoAcesso != '0')
			{
				LblModoDashboard.Text = "Você está no modo de Funcionário";

				BtnCadastrarFuncionario.Visible = false;
				BtnPesquisarFuncionario.Visible = false;

				BtnCadastrarUsuário.Visible = false;
				BtnPesquisarUsuario.Visible = false;
			}
			else
			{
				LblModoDashboard.Text = "Você está no modo de Administrador";

				BtnCadastrarFuncionario.Visible = true;
				BtnPesquisarFuncionario.Visible = true;

				BtnCadastrarUsuário.Visible = true;
				BtnPesquisarUsuario.Visible = true;
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			FrmCadastroUsuario frmcadastrousuario = new FrmCadastroUsuario();
			frmcadastrousuario.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			PesquisaUsuarios pesquisausuario = new PesquisaUsuarios();
			pesquisausuario.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			CadastraCliente cliente = new CadastraCliente();
			cliente.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			PesquisaCliente pesquisaCliente = new PesquisaCliente();
			pesquisaCliente.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			CadastroServico cadastroServico = new CadastroServico();
			cadastroServico.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			PesquisaServico pesquisaServico = new PesquisaServico();
			pesquisaServico.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			CadastroHorario cadastroHorario = new CadastroHorario();
			cadastroHorario.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			PesquisaHorario pesquisaHorario = new PesquisaHorario();
			pesquisaHorario.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
			cadastroFuncionario.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			PesquisaFuncionario pesquisaFuncionario = new PesquisaFuncionario();
			pesquisaFuncionario.Show();
		}
	}
}


