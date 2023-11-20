﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Funcionario : Base
    {
		public Funcionario() { }
        public Funcionario(int id, string nomefuncionario, string nascfuncionario, string telefone, string cpffuncionario, string rgfuncionario, string enderecofuncionario, string codcargo, string emailfuncionario, double salario)
        {
			Id = id;
            Nome = nomefuncionario;
            DataNasc = nascfuncionario;
            Telefone = telefone;
            CPF = cpffuncionario;
            RG = rgfuncionario;
            Endereco = enderecofuncionario;
            Cargo = codcargo;
            Email = emailfuncionario;
			Salario = salario;
        }
        public string Nome { get; set; }
		public string DataNasc { get; set; }
        public string Telefone { get; set; }
		public string CPF { get; set; }
		public string RG { get; set; }
		public string Endereco { get; set; }
		public string Cargo { get; set; }
		public string Email { get; set; }

		public double Salario;

		public MySqlDataReader LocalizaPorNome()
		{
			try
			{
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
				MySqlConexaoBanco.Open();
				string select = $"select id, nome, telefone, datanasc, cpf, rg, endereco, email, cargo, salario from funcionarios where nome like '%{this.Nome}%';";
				MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
				comandoSQL.CommandText = select;
				MySqlDataReader reader = comandoSQL.ExecuteReader();
				return reader;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro no banco de dados - método localizarPorNome: " + ex.Message);
				return null;
			}


		}
		public MySqlDataReader LocalizaPorCPF()
		{
			try
			{
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
				MySqlConexaoBanco.Open();
				string select = $"select id, nome, telefone, datanasc, cpf, rg, endereco, email, cargo, salario from funcionarios where cpf like '%{this.CPF}%';";
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
		public void Alterar()
		{
			var connection = new MySqlConnection(Conexao.strConexao);

			this.DataNasc = (DateTime.Parse(this.DataNasc)).ToString("yyyy-MM-dd");
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			connection.Open();
			MySqlCommand cmd = new MySqlCommand($"UPDATE funcionarios SET nome = '{this.Nome}', telefone = '{this.Telefone}', datanasc = '{this.DataNasc}', cpf = '{this.CPF}', rg = '{this.RG}', endereco = '{this.Endereco}', email = '{this.Email}', cargo = '{this.Cargo}', salario = {this.Salario} WHERE id = '{this.Id}'", connection);
			cmd.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Registro atualizado com sucesso.");

            PesquisaFuncionario f1 = (PesquisaFuncionario)Application.OpenForms["PesquisaFuncionario"];
            f1.PesquisarTodosFuncionarios();
        }

	}
}
