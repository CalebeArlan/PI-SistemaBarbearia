﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
	public class Horario:Base
	{
		public Horario() { }
		public Horario(int idhorario, int codcliente, int codservico, string hora, string datahorario)
		{
			this.DataHorario = datahorario;
			this.Id = idhorario;
			this.Hora = hora;
			this.CodCliente = codcliente;
			this.CodServico = codservico;
			
		}

		public MySqlDataReader LocalizaPorNome(string nome)
		{
			try
			{
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
				MySqlConexaoBanco.Open();
				string select = $"SELECT \r\n    h.id,\r\n    c.nome AS nome_cliente,\r\n    s.nome AS nome_servico,\r\n    h.hora,\r\n    h.data_horario\r\nFROM \r\n    horarios h\r\nJOIN \r\n    clientes c ON h.cod_cliente = c.id\r\nJOIN \r\n    servicos s ON h.cod_servico = s.id\r\nWHERE \r\n    c.nome like '%{nome}%'";
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

		public MySqlDataReader LocalizaPorDia()
		{
			try
			{
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
				MySqlConexaoBanco.Open();
				string select = $"SELECT \r\n    h.id,\r\n    c.nome AS nome_cliente,\r\n    s.nome AS nome_servico,\r\n    h.hora,\r\n    h.data_horario\r\nFROM \r\n    horarios h\r\nJOIN \r\n    clientes c ON h.cod_cliente = c.id\r\nJOIN \r\n    servicos s ON h.cod_servico = s.id\r\n WHERE \r\n    h.data_horario = '{this.DataHorario}'";
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

		public static MySqlDataReader LocalizaTodos()
		{
			try
			{
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
				MySqlConexaoBanco.Open();
				string select = $"SELECT \r\n    h.id,\r\n    c.nome AS nome_cliente,\r\n    s.nome AS nome_servico,\r\n    h.hora,\r\n    h.data_horario\r\nFROM \r\n    horarios h\r\nJOIN \r\n    clientes c ON h.cod_cliente = c.id\r\nJOIN \r\n    servicos s ON h.cod_servico = s.id";
				MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
				comandoSQL.CommandText = select;
				MySqlDataReader reader = comandoSQL.ExecuteReader();
				return reader;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro no banco de dados - método localizaTodos - Horário.cs: " + ex.Message);
				return null;
			}


		}



		public int CodCliente;
		public int CodServico;
		public string Hora;
		public string DataHorario;
	}
}
