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
    public partial class FrmCadastroUsuario : Form
    {
        public string strConexao = "server=localhost;uid=root;database=barbearia";
        public FrmCadastroUsuario()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(0, TxtUsuario.Text, TxtSenha.Text, Convert.ToString(CbTipoAcesso.SelectedIndex));
            var connection = new MySqlConnection(strConexao);

            if (Funcoes.VerivicaVazio(this) == false)
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `usuarios`(`nome_usuario`, `senha`, `tipo_acesso`) VALUES ('" + usuario.NomeUsuario + "','" + usuario.Senha + "','" + usuario.TipoAcesso + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cadastrado com sucesso");
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
