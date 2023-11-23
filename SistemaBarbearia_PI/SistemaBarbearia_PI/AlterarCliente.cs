using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBarbearia_PI
{
	public partial class AlterarCliente : Form
	{
		public AlterarCliente(int id, string nome, string telefone, string email, string datanasc, string cpf, string rg)
		{
			InitializeComponent();

			LblId.Text = Convert.ToString(id);
			TxtNome.Text = nome;
			MtxtTelefone.Text = telefone;
			TxtEmail.Text = email;
			MtxtDataNasc.Text = datanasc;
			MtxtCPF.Text = cpf;
			MtxtRG.Text = rg;
		}

		private void BtnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				Cliente cliente = new Cliente(Convert.ToInt32(LblId.Text), TxtNome.Text, MtxtTelefone.Text, TxtEmail.Text, MtxtDataNasc.Text, MtxtCPF.Text, MtxtRG.Text);
				if (Funcoes.VerivicaVazio(this) == false)
				{
					cliente.Alterar();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao atualizar o registro. - AlterarCliente.cs " + ex.Message);
			}
		}

		private void BtnExcluir_Click(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente();
			cliente.Id = Int32.Parse(LblId.Text);

			var result = MessageBox.Show("Tem certeza que deseja excluir permanentemente este registro?", "Excluir Registro?", MessageBoxButtons.YesNo);
			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				cliente.Deletar();

				MessageBox.Show("Registro deletado com sucesso.");

				PesquisaCliente f1 = (PesquisaCliente)Application.OpenForms["PesquisaCliente"];
				f1.PesquisaTodosClientes();
				Close();
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
