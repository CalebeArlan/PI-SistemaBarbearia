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
	public partial class CadastroHorario : Form
	{
		public CadastroHorario()
		{
			InitializeComponent();
		}

		private void BtnCadastrar_Click(object sender, EventArgs e)
		{
			Horario horario = new Horario(0, Convert.ToInt32(dataGridView1.SelectedCells[0].Value), Convert.ToInt32(dataGridView2.SelectedCells[0].Value), DtpHorario.Text, DtpData.Text);
			var connection = new MySqlConnection(Conexao.strConexao);

			horario.DataHorario = DateTime.ParseExact(horario.DataHorario, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

			if (Funcoes.VerivicaVazio(this) == false)
			{
				Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
				connection.Open();
				MySqlCommand cmd = new MySqlCommand($"INSERT INTO `horarios`(`cod_cliente`, `cod_servico`, `hora`, `data_horario`) VALUES('{horario.CodCliente}','{horario.CodServico}','{horario.Hora}','{horario.DataHorario}')", connection);
				cmd.ExecuteNonQuery();
				connection.Close();
				MessageBox.Show("Cadastrado com sucesso");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				if (!TxtNome.Text.Equals(""))
				{
					Cliente cliente = new Cliente();
					cliente.Nome = TxtNome.Text;

					MySqlDataReader reader = cliente.LocalizaCliente(cliente.Nome);

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
								string? coluna4 = reader["email"].ToString();
								string? coluna5 = ((DateTime)reader["datanasc"]).Date.ToShortDateString();
								string? coluna6 = reader["cpf"].ToString();
								string? coluna7 = reader["rg"].ToString();

								dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5, coluna6, coluna7);
							}


						}
						else
						{
							MessageBox.Show("Cliente não encontrado.");
							TxtNome.Clear();
							TxtNome.Focus();
						}
					}
				}
				else
				{
					MessageBox.Show("Favor preencher o campo Nome para pesquisa");
					TxtNome.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao encontrar cliente: " + ex.Message);
			}
		}

		private void CadastroHorario_Load(object sender, EventArgs e)
		{
			MySqlDataReader reader = Cliente.LocalizaTodosClientes();
			dataGridView1.Rows.Clear();
			while (reader.Read())
			{
				string? coluna1 = reader["id"].ToString();
				string? coluna2 = reader["nome"].ToString();
				string? coluna3 = reader["telefone"].ToString();
				string? coluna4 = reader["email"].ToString();
				string? coluna5 = ((DateTime)reader["datanasc"]).Date.ToShortDateString();
				string? coluna6 = reader["cpf"].ToString();
				string? coluna7 = reader["rg"].ToString();

				dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5, coluna6, coluna7);
			}

			Servico servico = new Servico();
			reader = Servico.LocalizaTodos("servicos");
			dataGridView2.Rows.Clear();
			while (reader.Read())
			{
				string? coluna1 = reader["id"].ToString();
				string? coluna2 = reader["nome"].ToString();
				string? coluna3 = reader["preco"].ToString();
				string? coluna4 = reader["descricao"].ToString();

				dataGridView2.Rows.Add(coluna1, coluna2, coluna3, coluna4);
			}
		}

		private void TxtNome_Click(object sender, EventArgs e)
		{
			TxtNome.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (!TxtPesquisaServico.Text.Equals(""))
				{
					Servico servico = new Servico();
					servico.Nome = TxtPesquisaServico.Text;

					MySqlDataReader reader = servico.LocalizaPorNome(servico.Nome);

					if (reader != null)
					{
						if (reader.HasRows)
						{
							dataGridView2.Rows.Clear();
							while (reader.Read())
							{
								string? coluna1 = reader["id"].ToString();
								string? coluna2 = reader["nome"].ToString();
								string? coluna3 = reader["preco"].ToString();
								string? coluna4 = reader["descricao"].ToString();

								dataGridView2.Rows.Add(coluna1, coluna2, coluna3, coluna4);
							}
						}
						else
						{
							MessageBox.Show("Serviço não encontrado.");
							TxtPesquisaServico.Clear();
							TxtPesquisaServico.Focus();
						}
					}
				}
				else
				{
					MessageBox.Show("Favor preencher o campo Nome para pesquisa");
					TxtPesquisaServico.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao encontrar serviço: " + ex.Message);
			}
		}
	}
}
