using MySql.Data.MySqlClient;
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
	public partial class CadastroServico : Form
	{
		public CadastroServico()
		{
			InitializeComponent();
		}

		private void BtnCadastrar_Click(object sender, EventArgs e)
		{
			Servico servico = new Servico(0, TxtNome.Text, Double.Parse(TxtPreco.Text), TxtDescricao.Text);
			var connection = new MySqlConnection(Conexao.strConexao);

			if (Funcoes.VerivicaVazio(this) == false)
			{
				try
				{
					connection.Open();
					MySqlCommand cmd = new MySqlCommand($"INSERT INTO `servicos`(`nome`, `preco`, `descricao`) VALUES('{servico.Nome}','{servico.Preco}','{servico.Descricao}');", connection);
					cmd.ExecuteNonQuery();
					connection.Close();
					MessageBox.Show("Cadastrado com sucesso");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao realizar o cadastro - BtnCadastrar_Click " + ex.Message);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
