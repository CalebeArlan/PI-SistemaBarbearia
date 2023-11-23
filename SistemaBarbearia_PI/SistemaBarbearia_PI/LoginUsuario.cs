using MySql.Data.MySqlClient;
using System.Dynamic;
using System.Windows.Forms;

namespace SistemaBarbearia_PI
{
	public partial class FrmLoginUsuario : Form
	{
		public FrmLoginUsuario()
		{
			InitializeComponent();
		}

		public static char TipoAcesso; //Variável para comparação de níveis de acesso externa.

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				var conexao = new MySqlConnection(Conexao.strConexao);
				conexao.Open();
				MessageBox.Show("Conexão bem sucedida");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu um erro ao conectar ao banco de dados: " + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Usuario usuario = new Usuario();
			usuario.NomeUsuario = TxtUsuario.Text;
			usuario.Senha = TxtSenha.Text;
			var connection = new MySqlConnection(Conexao.strConexao);

			MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM usuarios where nome_usuario = '" + usuario.NomeUsuario + "' and senha = '" + usuario.Senha + "'", connection);
			connection.Open();

			int count = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			TxtSenha.Clear();
			TxtUsuario.Clear();

			if (count > 0)
			{
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
				MySqlConexaoBanco.Open();
				string select = $"SELECT tipo_acesso from usuarios where nome_usuario = '{usuario.NomeUsuario}' and senha = '{usuario.Senha}';";
				MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
				comandoSQL.CommandText = select;
				MySqlDataReader reader = comandoSQL.ExecuteReader();

				while (reader.Read())
				{
					TipoAcesso = Convert.ToChar((reader["tipo_acesso"]));
				}


				Menu form = new Menu();
				form.Show();

				this.Visible = false;
			}
			else
			{
				MessageBox.Show("Usuário ou senha inválidos. Acesso negado.");
			}


		}
	}
}