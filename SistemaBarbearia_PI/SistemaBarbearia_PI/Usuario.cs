using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Usuario
    {
        public Usuario() { }
		public Usuario(int idusuario, string nomeusuario, string senha, string tipoacesso)
        {
            IdUsuario = idusuario;
            NomeUsuario = nomeusuario;
            Senha = senha;
            TipoAcesso = tipoacesso;
        }
        public int IdUsuario;
        public string NomeUsuario;
        public string Senha;
        public string TipoAcesso;

        public MySqlDataReader LocalizaTodosUsuarios()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao) ;
                MySqlConexaoBanco.Open();
                string select = "select id, nome_usuario, senha, tipo_acesso from usuarios;";
                MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
                comandoSQL.CommandText = select;

                MySqlDataReader reader = comandoSQL.ExecuteReader();
                return reader;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método localizaTodosUsuario: " + ex.Message);
                return null;
            }
        }

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
    }
}
