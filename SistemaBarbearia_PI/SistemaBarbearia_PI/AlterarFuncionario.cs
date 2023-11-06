using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace SistemaBarbearia_PI
{
	public partial class AlterarFuncionario : Form
	{
		public AlterarFuncionario()
		{
			InitializeComponent();
		}
		public AlterarFuncionario(int id, string nome, string datanasc, string telefone, string cpf, string rg, string endereco, string cargo, string email, double salario)
		{
			InitializeComponent();

			LblId.Text = Convert.ToString(id);
			TxtNome.Text = nome;
			MtxtDataNasc.Text = datanasc;
			MtxtTelefone.Text = telefone;
			MtxtCPF.Text = cpf;
			MtxtRG.Text = rg;
			TxtEndereco.Text = endereco;
			TxtCargo.Text = cargo;
			TxtEmail.Text = email;
			TxtSalario.Text = salario.ToString();
		}

		private void BtnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
                Funcionario funcionario = new Funcionario(Convert.ToInt32(LblId.Text), TxtNome.Text, MtxtDataNasc.Text, MtxtTelefone.Text, MtxtCPF.Text, MtxtRG.Text, TxtEndereco.Text, TxtCargo.Text, TxtEmail.Text, Convert.ToDouble(TxtSalario.Text));
                if (Funcoes.VerivicaVazio(this) == false)
                {
                    funcionario.Alterar();

                }
            }
			catch(Exception ex)
			{
				MessageBox.Show("Erro ao atualizar o registro. - AlterarFuncionario.cs " + ex.Message);
			}
			
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnExcluir_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Tem certeza que deseja excluir permanentemente este registro?","Excluir Registro?", MessageBoxButtons.YesNo);
			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				//TODO EXCLUIR
			}
		}
	}
}
