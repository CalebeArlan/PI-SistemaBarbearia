using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class AlterarCliente : Form
    {
        public AlterarCliente(int id, string nome, string telefone, string email, string datanasc, string cpf, string rg)
        {
            InitializeComponent();

            TxtNome.Text = nome;
            MtxtTelefone.Text = telefone;
            TxtEmail.Text = email;
            MtxtDataNasc.Text = datanasc;
            MtxtCPF.Text = cpf;
            MtxtRG.Text = rg;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(0,TxtNome.Text, MtxtTelefone.Text, TxtEmail.Text, MtxtDataNasc.Text, MtxtCPF.Text, MtxtRG.Text);
                if (Funcoes.VerivicaVazio(this) == false)
                {
                    cliente.Alterar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o registro. - AlterarFuncionario.cs " + ex.Message);
            }
        }
    }
}
