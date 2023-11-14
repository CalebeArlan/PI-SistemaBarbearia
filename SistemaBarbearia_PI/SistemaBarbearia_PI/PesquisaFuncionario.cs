﻿using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;

namespace SistemaBarbearia_PI
{
	public partial class PesquisaFuncionario : Form
	{

		public PesquisaFuncionario()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (RdBNome.Checked == true)
			{
				try
				{
					if (!TxtBusca.Text.Equals(""))
					{
						Funcionario funcionario = new Funcionario();
						funcionario.Nome = TxtBusca.Text;

						MySqlDataReader reader = funcionario.LocalizaPorNome();

						if (reader != null)
						{
							if (reader.HasRows)
							{
								dataGridView1.Rows.Clear();
								while (reader.Read())
								{
									string? coluna1 = reader["id"].ToString();
									string? coluna2 = reader["nome"].ToString();
									string? coluna3 = reader["telefone"].ToString();
									string? coluna4 = ((DateTime)reader["datanasc"]).Date.ToShortDateString();
									//string? coluna4 = reader["datanasc"].ToString();
                                    string? coluna5 = reader["cpf"].ToString();
									string? coluna6 = reader["rg"].ToString();
									string? coluna7 = reader["endereco"].ToString();
									string? coluna8 = reader["email"].ToString();
									string? coluna9 = reader["cargo"].ToString();
									string? coluna10 = reader["salario"].ToString();

									dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5, coluna6, coluna7, coluna8, coluna9, coluna10);
								}
							}
							else
							{
								MessageBox.Show("Funcionário não encontrado.");
								TxtBusca.Clear();
								TxtBusca.Focus();
							}
						}
					}
					else
					{
						MessageBox.Show("Favor preencher o campo Nome para pesquisa");
						TxtBusca.Focus();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao encontrar funcionário: " + ex.Message);
				}
			}
			else if (RdbCPF.Checked == true)
			{
				try
				{
					if (!TxtBusca.Text.Equals(""))
					{
						Funcionario funcionario = new Funcionario();
						funcionario.CPF = TxtBusca.Text;

						MySqlDataReader reader = funcionario.LocalizaPorCPF();

						PesquisarTodosFuncionarios();
					}
					else
					{
						MessageBox.Show("Favor preencher o campo Nome para pesquisa");
						TxtBusca.Focus();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao encontrar funcionário: " + ex.Message);
				}
			}
		}



		public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Funcionario funcionario = new Funcionario();
			funcionario.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			funcionario.Nome = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
			funcionario.Telefone = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
			funcionario.DataNasc = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
			funcionario.CPF = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
			funcionario.RG = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
			funcionario.Endereco = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
			funcionario.Email = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
			funcionario.Cargo = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
			funcionario.Salario = Convert.ToDouble(dataGridView1.CurrentRow.Cells[9].Value);

			AlterarFuncionario alterarFuncionario = new AlterarFuncionario(funcionario.Id,funcionario.Nome,funcionario.DataNasc,funcionario.Telefone,funcionario.CPF,funcionario.RG,funcionario.Endereco,funcionario.Cargo,funcionario.Email,funcionario.Salario);
			alterarFuncionario.Show();
		}

		public void PesquisarTodosFuncionarios()
		{
			Funcionario funcionario = new Funcionario();
			MySqlDataReader reader = Funcionario.LocalizaTodos("funcionarios");
			dataGridView1.Rows.Clear();
			while (reader.Read())
			{
				string? coluna1 = reader["id"].ToString();
				string? coluna2 = reader["nome"].ToString();
				string? coluna3 = reader["telefone"].ToString();
				DateTime data = reader.GetDateTime("datanasc");
				string? coluna4 = data.ToShortDateString();
                string? coluna5 = reader["cpf"].ToString();
				string? coluna6 = reader["rg"].ToString();
				string? coluna7 = reader["endereco"].ToString();
				string? coluna8 = reader["email"].ToString();
				string? coluna9 = reader["cargo"].ToString();
				string? coluna10 = reader["salario"].ToString();

				dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5, coluna6, coluna7, coluna8, coluna9, coluna10);
			}
		}

		private void PesquisaUsuarios_Load(object sender, EventArgs e)
		{
			PesquisarTodosFuncionarios();
		}
		private void TxtNome_Click(object sender, EventArgs e)
		{
			TxtBusca.Clear();
		}

		private void BtnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
