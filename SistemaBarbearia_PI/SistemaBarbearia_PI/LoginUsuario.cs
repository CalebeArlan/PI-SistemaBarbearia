using MySql.Data.MySqlClient;
using System.Dynamic;

namespace SistemaBarbearia_PI
{
	public partial class FrmLoginUsuario : Form
	{
		public FrmLoginUsuario()
		{
			InitializeComponent();

		}

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
        public char Verifica_Acesso(string nome, string senha)
        {
			
			/* var connection = new MySqlConnection(Conexao.strConexao);
			 connection.Open();
			 MySqlCommand cmd = new MySqlCommand($"select tipo_acesso from usuarios where nome_usuario = {nome} and senha = {senha}", connection);
			 cmd.ExecuteNonQuery();
			 connection.Close();*/
			MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
			MySqlConexaoBanco.Open();
			string select = $"select tipo_acesso from usuarios where nome_usuario = {nome} and senha = {senha}";
			MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
			comandoSQL.CommandText = select;
			MySqlDataReader reader = comandoSQL.ExecuteReader();

            return tipo_acesso;
        }
        private void button1_Click(object sender, EventArgs e)
		{
			string usuario = TxtUsuario.Text;
			string senha = TxtSenha.Text;
			var connection = new MySqlConnection(Conexao.strConexao);

			MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM usuarios where nome_usuario = '" + usuario + "' and senha = '" + senha + "'", connection);
			connection.Open();


			int count = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			TxtSenha.Clear();
			TxtUsuario.Clear();

			if (count > 0)
			{
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