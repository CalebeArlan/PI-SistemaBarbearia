using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBarbearia_PI
{
	public partial class AlterarUsuario : Form
	{
		public AlterarUsuario()
		{
			InitializeComponent();
		}
		public AlterarUsuario(int idUsuario, string nomeUsuario, string tipoAcesso, string senha)
		{
			InitializeComponent();

			TxtUsuario.Text = nomeUsuario;
			LblId.Text = Convert.ToString(idUsuario);
			TxtSenha.Text = senha;
			CbTipoAcesso.SelectedIndex = Convert.ToInt32(tipoAcesso);
		}

		private void BtnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnCadastrar_Click(object sender, EventArgs e)
		{
			Usuario usuario = new Usuario(0, TxtUsuario.Text, TxtSenha.Text, Convert.ToString(CbTipoAcesso.SelectedIndex));
			
			if (Funcoes.VerivicaVazio(this) == false)
			{
				var connection = new MySqlConnection(Conexao.strConexao);
				connection.Open();
				try
				{
					MySqlCommand cmd = new MySqlCommand($"UPDATE usuarios SET nome_usuario = '{usuario.NomeUsuario}', senha = '{usuario.Senha}', tipo_acesso = {usuario.TipoAcesso} WHERE id = '{LblId.Text}'", connection);
					cmd.ExecuteNonQuery();
					connection.Close();
					MessageBox.Show("Registro alterado com sucesso.");

					PesquisaUsuarios f1 = (PesquisaUsuarios)Application.OpenForms["PesquisaUsuarios"];
					f1.PesquisarTodosUsuarios();


                }
                catch (Exception ex)
				{
					MessageBox.Show("Ocorreu um erro na alteração do registro. " + ex.Message);
				}
			}
		}
	}
}
