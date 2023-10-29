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

		private void AlterarUsuario_Load(object sender, EventArgs e)
		{

		}

		private void BtnCadastrar_Click(object sender, EventArgs e)
		{

		}
	}
}
