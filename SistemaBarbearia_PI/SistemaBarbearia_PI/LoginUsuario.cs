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
				MessageBox.Show("Conex�o bem sucedida");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu um erro ao conectar ao banco de dados: " + ex.Message);
			}




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
				MessageBox.Show("Usu�rio ou senha inv�lidos. Acesso negado.");
			}


		}
	}
}