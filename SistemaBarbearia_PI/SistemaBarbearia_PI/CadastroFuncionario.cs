using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBarbearia_PI
{
	public partial class CadastroFuncionario : Form
	{
		public CadastroFuncionario()
		{
			InitializeComponent();
		}

		private void BtnCadastrar_Click(object sender, EventArgs e)
		{
			Funcionario funcionario = new Funcionario(0, TxtNome.Text, MtxtDataNasc.Text, MtxtTelefone.Text, MtxtCPF.Text, MtxtRG.Text, TxtEndereco.Text, TxtCargo.Text, TxtEmail.Text, Double.Parse(TxtSalario.Text), CbSituacao.Text);
			var connection = new MySqlConnection(Conexao.strConexao);

			funcionario.DataNasc = DateTime.ParseExact(MtxtDataNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

			if (Funcoes.VerivicaVazio(this) == false)
			{
				Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
				connection.Open();
				MySqlCommand cmd = new MySqlCommand($"INSERT INTO `funcionarios`(`nome`, `telefone`, `datanasc`, `cpf`, `rg`, `endereco`, `email`, `cargo`, `salario`,`situacao`) VALUES('{funcionario.Nome}','{funcionario.Telefone}','{funcionario.DataNasc}','{funcionario.CPF}','{funcionario.RG}','{funcionario.Endereco}','{funcionario.Email}','{funcionario.Cargo}',{funcionario.Salario}, '{funcionario.Situacao}')", connection);
				cmd.ExecuteNonQuery();
				connection.Close();
				MessageBox.Show("Cadastrado com sucesso");


				TxtNome.Clear();
				TxtEndereco.Clear();
				TxtEmail.Clear();
				TxtCargo.Clear();
				TxtSalario.Clear();
				MtxtCPF.Clear();
				MtxtDataNasc.Clear();
				MtxtRG.Clear();
				MtxtTelefone.Clear();
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}
