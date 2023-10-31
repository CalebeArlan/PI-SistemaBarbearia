using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    
    public class Cliente : IPessoa
    {
        public string strConexao = "server=localhost;uid=root;database=barbearia";
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
        public int Id;
        public string Nome;
        public string Telefone;
        public string Email;
        public string DataNasc;
        public string CPF;
        public string RG;

    }
    public MySqlDataReader LocalizaTodosClientes()
    {
        try
        {
            MySqlConnection MySqlConexaoBanco = new MySqlConnection(strConexao);
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
            MySqlConnection MySqlConexaoBanco = new MySqlConnection(strConexao);
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
}
