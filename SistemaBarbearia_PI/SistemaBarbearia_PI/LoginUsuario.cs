using MySql.Data.MySqlClient;
using System.Dynamic;

namespace SistemaBarbearia_PI
{
    public partial class FrmLoginUsuario : Form
    {

        public string strConexao = "server=localhost;uid=root;database=barbearia";
        public FrmLoginUsuario()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                var conexao = new MySqlConnection(strConexao);
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
            string usuario = TxtUsuario.Text;
            string senha = TxtSenha.Text;
            var connection = new MySqlConnection(strConexao);

            MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM usuarios where nome_usuario = '" + usuario + "' and senha = '" + senha + "'", connection);
            connection.Open();


            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if (count > 0)
            {
                Menu form = new Menu();
                form.Show();
                
                this.Visible = false;
            }


        }
    }
}