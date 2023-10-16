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
		public string strConexao = "server=localhost;uid=root;database=barbearia";
		public Usuario(string nomeusuario, string senha, string tipoacesso)
        {

           // IdUsuario = idusuario; <-- Comentado porque ele precisava ser construido no construtor, porém na inserção não temos o id, porque é AutoIncrement.
           // Isso pode gerar problemas futuros.
            NomeUsuario = nomeusuario;
            Senha = senha;
            TipoAcesso = tipoacesso;
        }
       // public int IdUsuario;
        public string NomeUsuario;
        public string Senha;
        public string TipoAcesso;

        public MySqlDataReader LocalizaUsuario(string nome)
        {
            try
            {
				MySqlConnection MySqlConexaoBanco = new MySqlConnection(strConexao);
                MySqlConexaoBanco.Open();
                string select = $"select id, nome_usuario, tipoacesso from usuarios where nome like =  %'{nome}'%;";
                MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
                comandoSQL.CommandText = select;

                MySqlDataReader reader = comandoSQL.ExecuteReader();
                return reader;
			}
            catch (Exception ex)
            {
                return null;
            }
           
            
        }
    }
}
