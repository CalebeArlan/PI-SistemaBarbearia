﻿using MySql.Data.MySqlClient;
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
	public partial class AlterarUsuario : Form
	{
		public AlterarUsuario()
		{
			InitializeComponent();
		}
		public AlterarUsuario(int idUsuario, string nomeUsuario, string tipoAcesso, string senha)
		{
			InitializeComponent();

			TxtUsuario.Text = nomeUsuario;
			LblId.Text = Convert.ToString(idUsuario);
			TxtSenha.Text = senha;
			CbTipoAcesso.SelectedIndex = Convert.ToInt32(tipoAcesso);
		}

		private void BtnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnCadastrar_Click(object sender, EventArgs e)
		{
			Usuario usuario = new Usuario(int.Parse(LblId.Text), TxtUsuario.Text, TxtSenha.Text, Convert.ToString(CbTipoAcesso.SelectedIndex));

			if (Funcoes.VerivicaVazio(this) == false)
			{
				try
				{
					usuario.Alterar();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ocorreu um erro na alteração do registro. " + ex.Message);
				}
			}
		}

		private void BtnExcluir_Click(object sender, EventArgs e)
		{
			Usuario usuario = new Usuario();
			usuario.Id = Int32.Parse(LblId.Text);

			var result = MessageBox.Show("Tem certeza que deseja excluir permanentemente este registro?", "Excluir Registro?", MessageBoxButtons.YesNo);
			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				usuario.Deletar();

				MessageBox.Show("Registro deletado com sucesso.");

				PesquisaUsuarios f1 = (PesquisaUsuarios)Application.OpenForms["PesquisaUsuarios"];
				f1.PesquisarTodosUsuarios();
				Close();
			}
		}
	}
}
