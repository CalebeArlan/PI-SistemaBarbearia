using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
	public class Servico:Base
	{
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

		public MySqlDataReader LocalizaServico(string nome)
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
	}
}
