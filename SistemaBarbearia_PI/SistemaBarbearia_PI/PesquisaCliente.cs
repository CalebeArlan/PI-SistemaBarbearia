﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;
namespace SistemaBarbearia_PI
{
    public partial class PesquisaCliente : Form
    {
        public PesquisaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TxtNome.Text.Equals(""))
                {
                    Usuario usuario = new Usuario();
                    usuario.NomeUsuario = TxtNome.Text;

                    MySqlDataReader reader = usuario.LocalizaUsuario(usuario.NomeUsuario);

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                string? coluna1 = reader["id"].ToString();
                                string? coluna2 = reader["nome_usuario"].ToString();
                                string? coluna3 = reader["tipo_acesso"].ToString();

                                dataGridView1.Rows.Add(coluna1, coluna2, coluna3);
                            }


                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                            TxtNome.Clear();
                            TxtNome.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo Nome para pesquisa");
                    TxtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar usuário: " + ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            cliente.Nome = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            cliente.Telefone = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            cliente.Email = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            cliente.DataNasc = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            cliente.CPF = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            cliente.RG = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);

            /* AlterarCliente alterarcliente = new AlterarCliente();
             alterarcliente.Show();*/
        }

        private void TxtNome_Click(object sender, EventArgs e)
        {
            TxtNome.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisaCliente_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            MySqlDataReader reader = Cliente.LocalizaTodosClientes();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                
                
            }
        }
    }
}
