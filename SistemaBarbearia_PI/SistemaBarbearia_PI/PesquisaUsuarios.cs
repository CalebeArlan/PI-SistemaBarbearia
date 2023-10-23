﻿using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;

namespace SistemaBarbearia_PI
{
    public partial class PesquisaUsuarios : Form
    {
        public PesquisaUsuarios()
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



            AlterarUsuario alterarusuario = new AlterarUsuario();
            alterarusuario.Show();
        }

        private void PesquisaUsuarios_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            MySqlDataReader reader = usuario.LocalizaTodosUsuarios();

            while (reader.Read())
            {
                string? coluna1 = reader["id"].ToString();
                string? coluna2 = reader["nome_usuario"].ToString();
                string? coluna3 = reader["tipo_acesso"].ToString();

                dataGridView1.Rows.Add(coluna1, coluna2, coluna3);
            }


        }

        private void TxtNome_Click(object sender, EventArgs e)
        {
            TxtNome.Clear();
        }
    }
}
