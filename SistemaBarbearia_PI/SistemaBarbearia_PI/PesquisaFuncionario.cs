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
	public partial class PesquisaFuncionario : Form
	{

		public PesquisaFuncionario()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (!TxtNome.Text.Equals(""))
				{
					Funcionario funcionario = new Funcionario();
					funcionario.Nome = TxtNome.Text;

					MySqlDataReader reader = funcionario.LocalizaFuncionario(funcionario.Nome);

					if (reader != null)
					{
						if (reader.HasRows)
						{
							dataGridView1.Rows.Clear();
							while (reader.Read())
							{
								string? coluna1 = reader["id"].ToString();
								string? coluna2 = reader["nome"].ToString();
								string? coluna3 = ((DateTime)reader["datanasc"]).Date.ToShortDateString();
								string? coluna4 = reader["cpf"].ToString();
								string? coluna5 = reader["rg"].ToString();
								string? coluna6 = reader["endereco"].ToString();
								string? coluna7 = reader["email"].ToString();
								string? coluna8 = reader["cargo"].ToString();

								dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5, coluna6, coluna7, coluna8);
							}


						}
						else
						{
							MessageBox.Show("Funcionário não encontrado.");
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
				MessageBox.Show("Erro ao encontrar funcionário: " + ex.Message);
			}
		}

		public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Usuario usuarioAlterar = new Usuario();
			usuarioAlterar.IdUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			usuarioAlterar.NomeUsuario = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
			usuarioAlterar.Senha = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
			usuarioAlterar.TipoAcesso = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);

			AlterarUsuario alterarusuario = new AlterarUsuario(usuarioAlterar.IdUsuario, usuarioAlterar.NomeUsuario, usuarioAlterar.TipoAcesso, usuarioAlterar.Senha);
			alterarusuario.Show();
		}

		public void PesquisarTodosUsuarios()
		{
			Funcionario funcionario = new Funcionario();
			MySqlDataReader reader = Funcionario.LocalizaTodosFuncionarios();
			dataGridView1.Rows.Clear();
			while (reader.Read())
			{
				string? coluna1 = reader["id"].ToString();
				string? coluna2 = reader["nome"].ToString();
				string? coluna3 = ((DateTime)reader["datanasc"]).Date.ToShortDateString();
				string? coluna4 = reader["cpf"].ToString();
				string? coluna5 = reader["rg"].ToString();
				string? coluna6 = reader["endereco"].ToString();
				string? coluna7 = reader["email"].ToString();
				string? coluna8 = reader["cargo"].ToString();

				dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5, coluna6, coluna7, coluna8);
			}
		}

		private void PesquisaUsuarios_Load(object sender, EventArgs e)
		{
			Usuario usuario = new Usuario();
			MySqlDataReader reader = Funcionario.LocalizaTodosFuncionarios();

			while (reader.Read())
			{
				string? coluna1 = reader["id"].ToString();
				string? coluna2 = reader["nome"].ToString();
				string? coluna3 = ((DateTime)reader["datanasc"]).Date.ToShortDateString();
				string? coluna4 = reader["cpf"].ToString();
				string? coluna5 = reader["rg"].ToString();
				string? coluna6 = reader["endereco"].ToString();
				string? coluna7 = reader["email"].ToString();
				string? coluna8 = reader["cargo"].ToString();

				dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5, coluna6, coluna7, coluna8);
			}
		}

		private void TxtNome_Click(object sender, EventArgs e)
		{
			TxtNome.Clear();
		}

		private void BtnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
