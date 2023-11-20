using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    
    public class Cliente : Base
    {
        public Cliente() { }
        public Cliente(int idcliente, string nomecliente, string telefonecliente, string emailcliente, string nasccliente, string cpfcliente, string rgcliente)
        {
            Id = idcliente;
            Nome = nomecliente;
            Telefone = telefonecliente;
            Email = emailcliente;
            DataNasc = nasccliente;
            CPF = cpfcliente;
            RG = rgcliente;
            
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string DataNasc { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

        public static MySqlDataReader LocalizaTodosClientes()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
                MySqlConexaoBanco.Open();
                string select = "select id, nome, telefone, email, datanasc, cpf, rg from clientes;";
                MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
                comandoSQL.CommandText = select;

                MySqlDataReader reader = comandoSQL.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método localizaTodosClientes: " + ex.Message);
                return null;
            }
        }

        public MySqlDataReader LocalizaCliente(string nome)
        {

            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.strConexao);
                MySqlConexaoBanco.Open();
                string select = $"select id, nome, telefone, email, datanasc, cpf, rg from clientes where nome like '%{nome}%';";
                MySqlCommand comandoSQL = MySqlConexaoBanco.CreateCommand();
                comandoSQL.CommandText = select;
                MySqlDataReader reader = comandoSQL.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método localizarCliente: " + ex.Message);
                return null;
            }
        }
        public void Alterar()
        {
            var connection = new MySqlConnection(Conexao.strConexao);

            this.DataNasc = (DateTime.Parse(this.DataNasc)).ToString("yyyy-MM-dd");
          //this.DataNasc = (DateTime.Parse(this.DataNasc)).ToString("yyyy-MM-dd");

            connection.Open();
            MySqlCommand cmd = new MySqlCommand($"UPDATE clientes SET nome = '{this.Nome}', telefone = '{this.Telefone}', email = '{this.Email}', datanasc = {this.DataNasc}, cpf = '{this.CPF}', rg = '{this.RG}' WHERE id = '{this.Id}'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Registro atualizado com sucesso.");

            PesquisaCliente c1 = (PesquisaCliente)Application.OpenForms["PesquisaCliente"];
            c1.PesquisaTodosClientes();
        }
    }
    
}
