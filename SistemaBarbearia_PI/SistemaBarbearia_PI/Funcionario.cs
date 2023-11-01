using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Funcionario : IPessoa
    {
		public Funcionario() { }
        public Funcionario(int idfuncionario, string nomefuncionario, string nascfuncionario, string telefone, string cpffuncionario, string rgfuncionario, string enderecofuncionario, string codcargo, string emailfuncionario)
        {
            Id = idfuncionario;
            Nome = nomefuncionario;
            DataNasc = nascfuncionario;
            Telefone = telefone;
            CPF = cpffuncionario;
            RG = rgfuncionario;
            Endereco = enderecofuncionario;
            Cargo = codcargo;
            Email = emailfuncionario;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
		public string DataNasc { get; set; }
        public string Telefone { get; set; }
		public string CPF { get; set; }
		public string RG { get; set; }
		public string Endereco { get; set; }
		public string Cargo { get; set; }
		public string Email { get; set; }

		public static MySqlDataReader LocalizaTodosFuncionarios()
		{
			try
			{
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
				MySqlConexaoBanco.Open();
				string select = "select id, nome, datanasc, cpf, rg, endereco, email, cargo from funcionarios;";
				MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
				comandoSQL.CommandText = select;

				MySqlDataReader reader = comandoSQL.ExecuteReader();
				return reader;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro no banco de dados - método localizaTodosFuncionarios: " + ex.Message);
				return null;
			}
		}

		public MySqlDataReader LocalizaFuncionario(string nome)
		{
			try
			{
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
				MySqlConexaoBanco.Open();
				string select = $"select select id, nome, datanasc, cpf, rg, endereco, email, cargo where nome like '%{nome}%';";
				MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
				comandoSQL.CommandText = select;
				MySqlDataReader reader = comandoSQL.ExecuteReader();
				return reader;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro no banco de dados - método localizarFuncionario: " + ex.Message);
				return null;
			}


		}

	}
}
