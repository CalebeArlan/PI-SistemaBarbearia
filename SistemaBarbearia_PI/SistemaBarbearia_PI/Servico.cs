using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
	public class Servico:Base
	{
		public Servico() { }
		public Servico(int idservico, string nomeservico, double preco, string descricao)
		{
			this.Id = idservico;
			this.Nome = nomeservico;
			this.Preco = preco;
			this.Descricao = descricao;
		}
		public string Nome;
		public double Preco;
		public string Descricao;

		public MySqlDataReader LocalizaPorNome(string nome)
		{
			try
			{
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
				MySqlConexaoBanco.Open();
				string select = $"select id, nome, preco, descricao from servicos where nome like '%{nome}%';";
				MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
				comandoSQL.CommandText = select;
				MySqlDataReader reader = comandoSQL.ExecuteReader();
				return reader;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro no banco de dados - método localizaServico: " + ex.Message);
				return null;
			}
		}
		public void Alterar()
		{
			var connection = new MySqlConnection(Conexao.strConexao);
			connection.Open();
			MySqlCommand cmd = new MySqlCommand($"UPDATE servicos SET nome = '{this.Nome}', preco = '{this.Preco}', descricao = '{this.Descricao}' WHERE id = '{this.Id}'", connection);
			cmd.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Registro atualizado com sucesso.");

			PesquisaServico f1 = (PesquisaServico)Application.OpenForms["PesquisaServico"];
			f1.PesquisarTodosServicos();
		}
	}
}
