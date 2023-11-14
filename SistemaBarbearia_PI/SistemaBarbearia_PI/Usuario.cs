using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Usuario:Base
    {
        public Usuario() { }
		public Usuario(int idusuario, string nomeusuario, string senha, string tipoacesso)
        {
            Id = idusuario;
            NomeUsuario = nomeusuario;
            Senha = senha;
            TipoAcesso = tipoacesso;
        }
        public string NomeUsuario;
        public string Senha;
        public string TipoAcesso;

        public MySqlDataReader LocalizaUsuario(string nome)
        {
            try
            {
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
                MySqlConexaoBanco.Open();
                string select = $"select id, nome_usuario, senha, tipo_acesso from usuarios where nome_usuario like '%{nome}%';";
                MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
                comandoSQL.CommandText = select;
                MySqlDataReader reader = comandoSQL.ExecuteReader();
                return reader;

			}
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método localizarUsuario: " + ex.Message);
                return null;
            }
           
            
        }
		public void Alterar()
        {
			var connection = new MySqlConnection(Conexao.strConexao);
			connection.Open();
			MySqlCommand cmd = new MySqlCommand($"UPDATE usuarios SET nome_usuario = '{this.NomeUsuario}', senha = '{this.Senha}', tipo_acesso = {this.TipoAcesso} WHERE id = '{this.Id}'", connection);
			cmd.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Registro alterado com sucesso.");

			PesquisaUsuarios f1 = (PesquisaUsuarios)Application.OpenForms["PesquisaUsuarios"];
			f1.PesquisarTodosUsuarios();
		}
    }
}
