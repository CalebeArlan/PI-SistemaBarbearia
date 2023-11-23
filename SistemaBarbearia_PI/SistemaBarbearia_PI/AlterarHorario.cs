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
	public partial class AlterarHorario : Form
	{
		public AlterarHorario()
		{
			InitializeComponent();
		}
		public AlterarHorario(int id, int cod_cliente, int cod_servico, string hora, string data_horario)
		{
			InitializeComponent();

			SelecionarLinhaPorID(cod_cliente, dataGridView1);
			SelecionarLinhaPorID(cod_servico, dataGridView2);
			LblId.Text = Convert.ToString(id);
			DtpHorario.Text = hora;
			DtpData.Text = data_horario;


		}

		private void SelecionarLinhaPorID(int id, DataGridView datagrid)
		{
			foreach (DataGridViewRow row in datagrid.Rows)
			{
				if( row.Index > 0)
				{
					int idDaLinha = Convert.ToInt32(row.Cells["id"].Value);

					if (idDaLinha == id)
					{
						row.Selected = true;
						break;
					}
				}
				
			}
		}

		private void BtnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				Horario horario = new Horario(Int32.Parse(LblId.Text), Convert.ToInt32(dataGridView1.SelectedCells[0].Value), Convert.ToInt32(dataGridView2.SelectedCells[0].Value), DtpHorario.Text, DtpData.Text);

				if (Funcoes.VerivicaVazio(this) == false)
				{
					horario.Alterar();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao atualizar o registro. - AlterarServico.cs " + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnExcluir_Click(object sender, EventArgs e)
		{
			Servico servico = new Servico();
			servico.Id = Int32.Parse(LblId.Text);

			var result = MessageBox.Show("Tem certeza que deseja excluir permanentemente este registro?", "Excluir Registro?", MessageBoxButtons.YesNo);
			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				servico.Deletar();

				MessageBox.Show("Registro deletado com sucesso.");

				PesquisaHorario f1 = (PesquisaHorario)Application.OpenForms["PesquisaHorario"];
				f1.PesquisarTodosHorarios();
				Close();
			}
		}

		private void AtualizaTabelas()
		{
			MySqlDataReader reader = Cliente.LocalizaTodosClientes();
			dataGridView1.Rows.Clear();
			while (reader.Read())
			{
				string? coluna1 = reader["id"].ToString();
				string? coluna2 = reader["nome"].ToString();
				string? coluna3 = reader["telefone"].ToString();
				string? coluna4 = reader["email"].ToString();
				string? coluna5 = ((DateTime)reader["datanasc"]).Date.ToShortDateString();
				string? coluna6 = reader["cpf"].ToString();
				string? coluna7 = reader["rg"].ToString();

				dataGridView1.Rows.Add(coluna1, coluna2, coluna3, coluna4, coluna5, coluna6, coluna7);
			}

			reader = Base.LocalizaTodos("servicos");
			dataGridView2.Rows.Clear();
			while (reader.Read())
			{
				string? coluna1 = reader["id"].ToString();
				string? coluna2 = reader["nome"].ToString();
				string? coluna3 = reader["preco"].ToString();
				string? coluna4 = reader["descricao"].ToString();

				dataGridView2.Rows.Add(coluna1, coluna2, coluna3, coluna4);
			}

		}
		private void AlterarHorario_Load(object sender, EventArgs e)
		{
			AtualizaTabelas();
		}
	}
}
