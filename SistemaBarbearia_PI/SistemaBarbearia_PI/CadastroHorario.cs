﻿using MySql.Data.MySqlClient;
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
    public partial class CadastroHorario : Form
    {
        public CadastroHorario()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            /*funcionario funcionario = new Funcionario(0, TxtNome.Text, MtxtDataNasc.Text, MtxtTelefone.Text, MtxtCPF.Text, MtxtRG.Text, TxtEndereco.Text, TxtCargo.Text, TxtEmail.Text, Double.Parse(TxtSalario.Text));
            var connection = new MySqlConnection(Conexao.strConexao);

            funcionario.DataNasc = DateTime.ParseExact(MtxtDataNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

            if (Funcoes.VerivicaVazio(this) == false)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `funcionarios`(`nome`, `telefone`, `datanasc`, `cpf`, `rg`, `endereco`, `email`, `cargo`, `salario`) VALUES('{funcionario.Nome}','{funcionario.Telefone}','{funcionario.DataNasc}','{funcionario.CPF}','{funcionario.RG}','{funcionario.Endereco}','{funcionario.Email}','{funcionario.Cargo}',{funcionario.Salario})", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cadastrado com sucesso");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
