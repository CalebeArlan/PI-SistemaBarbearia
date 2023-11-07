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
    public partial class CadastraCliente : Form
    {
        public CadastraCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(0, TxtNome.Text, MtxtTelefone.Text, TxtEmail.Text, MtxtDataNasc.Text, MtxtCPF.Text, MtxtRG.Text);
            var connection = new MySqlConnection(Conexao.strConexao);

            cliente.DataNasc = (DateTime.Parse(cliente.DataNasc)).ToString("yyyy-MM-dd");

            if (Funcoes.VerivicaVazio(this) == false)
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `cliente`(`nome`, `telefone`, `email`, `datanasc`, `cpf`, `rg`) VALUES('{cliente.Nome}','{cliente.Telefone}','{cliente.Email}','{cliente.DataNasc}','{cliente.CPF}','{cliente.RG});", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cadastrado com sucesso");
            }
        }
    }
}
