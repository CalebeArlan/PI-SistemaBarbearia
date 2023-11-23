using MySql.Data.MySqlClient;
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
	public partial class PesquisaHorario : Form
	{

		public PesquisaHorario()
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
						Horario horario = new Horario();

						MySqlDataReader reader = horario.LocalizaPorNome(TxtBusca.Text);

						if (reader != null)
						{
							if (reader.HasRows)
							{
								dataGridView1.Rows.Clear();
								while (reader.Read())
								{
									string? coluna1 = reader["id"].ToString();
									string? coluna2 = reader["nome_cliente"].ToString();
									string? coluna3 = reader["nome_servico"].ToString();
									string? coluna4 = reader["hora"].ToString();
									string? coluna5 = ((DateTime)reader["data_horario"]).Date.ToShortDateString();

									dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5);
								}
							}
							else
							{
								MessageBox.Show("Horário não encontrado.");
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
					MessageBox.Show("Erro ao encontrar horário: " + ex.Message);
				}
			}
			else if (RdbData.Checked == true)
			{
				try
				{
					if (!TxtBusca.Text.Equals(""))
					{
						Horario horario = new Horario();
						horario.DataHorario = DtpData.Text;

						DateTime data = DateTime.ParseExact(horario.DataHorario, "dd/MM/yyyy", null);
						horario.DataHorario = data.ToString("yyyy-MM-dd");

						MySqlDataReader reader = horario.LocalizaPorDia();

						if (reader != null)
						{
							if (reader.HasRows)
							{
								dataGridView1.Rows.Clear();
								while (reader.Read())
								{
									string? coluna1 = reader["id"].ToString();
									string? coluna2 = reader["nome_cliente"].ToString();
									string? coluna3 = reader["nome_servico"].ToString();
									string? coluna4 = reader["hora"].ToString();
									string? coluna5 = ((DateTime)reader["data_horario"]).Date.ToShortDateString();

									dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5);
								}
							}
							else
							{
								MessageBox.Show("Horário não encontrado.");
								DtpData.Focus();
								dataGridView1.Rows.Clear();
							}
						}
					}
					else
					{
						MessageBox.Show("Favor preencher o campo Data para pesquisa");
						TxtBusca.Focus();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao encontrar horário: " + ex.Message);
				}
			}
		}



		public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Horario horario = new Horario();
			horario.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

			MySqlDataReader reader = horario.LocalizaCods();

			reader.Read();
			horario.CodCliente = Convert.ToInt32(reader["cod_cliente"]);
			horario.CodServico = Convert.ToInt32(reader["cod_servico"]);
			horario.Hora = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
			horario.DataHorario = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);

			AlterarHorario alterarHorario = new AlterarHorario(horario.Id, horario.CodCliente, horario.CodServico, horario.Hora, horario.DataHorario);
			alterarHorario.Show();
		}

		public void PesquisarTodosHorarios()
		{
			Horario horario = new Horario();
			MySqlDataReader reader = Horario.LocalizaTodos();
			dataGridView1.Rows.Clear();
			while (reader.Read())
			{
				string? coluna1 = reader["id"].ToString();
				string? coluna2 = reader["nome_cliente"].ToString();
				string? coluna3 = reader["nome_servico"].ToString();
				string? coluna4 = reader["hora"].ToString();
				string? coluna5 = ((DateTime)reader["data_horario"]).Date.ToShortDateString();

				dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5);
			}
		}

		private void PesquisaUsuarios_Load(object sender, EventArgs e)
		{
			PesquisarTodosHorarios();
		}
		private void TxtNome_Click(object sender, EventArgs e)
		{
			TxtBusca.Clear();
		}

		private void BtnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void RdbCPF_CheckedChanged(object sender, EventArgs e)
		{
			DtpData.Visible = true;
			TxtBusca.Visible = false;
		}

		private void RdBNome_CheckedChanged(object sender, EventArgs e)
		{
			DtpData.Visible = false;
			TxtBusca.Visible = true;
		}

		private void BtnPesquisaTodos_Click(object sender, EventArgs e)
		{
			TxtBusca.Clear();
			PesquisarTodosHorarios();
		}
	}
}
