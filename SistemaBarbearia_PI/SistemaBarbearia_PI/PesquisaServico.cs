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
	public partial class PesquisaServico : Form
	{

		public PesquisaServico()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (!TxtBusca.Text.Equals(""))
				{
					Servico servico = new Servico();
					servico.Nome = TxtBusca.Text;

					MySqlDataReader reader = servico.LocalizaPorNome(servico.Nome);

					if (reader != null)
					{
						if (reader.HasRows)
						{
							dataGridView1.Rows.Clear();
							while (reader.Read())
							{
								string? coluna1 = reader["id"].ToString();
								string? coluna2 = reader["nome"].ToString();
								string? coluna3 = reader["preco"].ToString();
								string? coluna4 = reader["descricao"].ToString();

								dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4);
							}
						}
						else
						{
							MessageBox.Show("Serviço não encontrado.");
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
				MessageBox.Show("Erro ao encontrar serviço: " + ex.Message);
			}
		}



		public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Servico servico = new Servico();
			servico.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			servico.Nome = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
			servico.Preco = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value);
			servico.Descricao = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);

			AlterarServico alterarServico = new AlterarServico(servico.Id, servico.Nome, servico.Preco, servico.Descricao);
			alterarServico.Show();
		}

		public void PesquisarTodosServicos()
		{
			Servico servico = new Servico();
			MySqlDataReader reader = Servico.LocalizaTodos("servicos");
			dataGridView1.Rows.Clear();
			while (reader.Read())
			{
				string? coluna1 = reader["id"].ToString();
				string? coluna2 = reader["nome"].ToString();
				string? coluna3 = reader["preco"].ToString();
				string? coluna4 = reader["descricao"].ToString();

				dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4);
			}
		}

		private void PesquisaUsuarios_Load(object sender, EventArgs e)
		{
			PesquisarTodosServicos();
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
