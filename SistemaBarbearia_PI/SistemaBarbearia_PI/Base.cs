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
	}
}
