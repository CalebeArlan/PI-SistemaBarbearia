using MySql.Data.MySqlClient;
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

namespace SistemaBarbearia_PI
{
	public partial class PesquisaUsuarios : Form
	{
		public PesquisaUsuarios()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (!TxtNome.Text.Equals(""))
				{
					Usuario usuario = new Usuario();
					usuario.NomeUsuario = TxtNome.Text;

					MySqlDataReader reader = usuario.LocalizaUsuario(usuario.NomeUsuario);

					if (reader != null)
					{
						if (reader.HasRows)
						{
							reader.Read();
							string coluna1 = reader["id"].ToString();
							string coluna2 = reader["nome_usuario"].ToString();
							string coluna3 = reader["tipo_acesso"].ToString();

							dataGridView1.Rows.Add(coluna1, coluna2, coluna3);
						}
						else
						{


							/*string coluna1 = leitor["NomeDaColuna1"].ToString();
							string coluna2 = leitor["NomeDaColuna2"].ToString();

							// Adicione os dados ao DataGridView
							dataGridView1.Rows.Add(coluna1, coluna2);*/

						}
					}
					else
					{
						MessageBox.Show("Usuário não encontrado.");
						TxtNome.Clear();
						TxtNome.Focus();
					}
				}
				else
				{
					MessageBox.Show("Favor preencher o campo Nome para pesquisa");
					TxtNome.Clear();
					TxtNome.Focus();

				}
			}
			catch (Exception)
			{
				//MessageBox.Show("Erro ao encontrar usuário: " + ex.Message);
			}
		}
	}
}
