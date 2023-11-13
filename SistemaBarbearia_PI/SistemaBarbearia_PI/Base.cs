using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
	public class Base
	{
		public int Id;
		public void Deletar()
		{
			string nome = this.GetType().Name + "s";
			var connection = new MySqlConnection(Conexao.strConexao);

			connection.Open();
			MySqlCommand cmd = new MySqlCommand($"DELETE FROM {nome} WHERE id = {this.Id}", connection);
			cmd.ExecuteNonQuery();
			connection.Close();
		}

		public MySqlDataReader LocalizaTodos()
		{
			try
			{
				string nome = this.GetType().Name + "s";
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
				MySqlConexaoBanco.Open();
				string select = $"select * from {nome};";
				MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
				comandoSQL.CommandText = select;

				MySqlDataReader reader = comandoSQL.ExecuteReader();
				return reader;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro no banco de dados - método localizaTodos: " + ex.Message);
				return null;
			}
		}
	}
}
