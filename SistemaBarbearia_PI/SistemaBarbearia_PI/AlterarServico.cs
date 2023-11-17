using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace SistemaBarbearia_PI
{
	public partial class AlterarServico : Form
	{
		public AlterarServico()
		{
			InitializeComponent();
		}
		public AlterarServico(int id, string nome, double preco, string descricao)
		{
			InitializeComponent();

			LblId.Text = Convert.ToString(id);
			TxtNome.Text = nome;
			TxtPreco.Text = preco.ToString();
			TxtDescricao.Text = descricao;

		}

		private void BtnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				Servico servico = new Servico(Convert.ToInt32(LblId.Text), TxtNome.Text, Convert.ToDouble(TxtPreco.Text), TxtDescricao.Text);
				if (Funcoes.VerivicaVazio(this) == false)
				{
					servico.Alterar();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao atualizar o registro. - AlterarServico.cs " + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnExcluir_Click(object sender, EventArgs e)
		{
			Servico servico = new Servico();
			servico.Id = Int32.Parse(LblId.Text);

			var result = MessageBox.Show("Tem certeza que deseja excluir permanentemente este registro?", "Excluir Registro?", MessageBoxButtons.YesNo);
			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				servico.Deletar();

				MessageBox.Show("Registro deletado com sucesso.");

				PesquisaServico f1 = (PesquisaServico)Application.OpenForms["PesquisaServico"];
				f1.PesquisarTodosServicos();
				Close();
			}
		}
	}
}
