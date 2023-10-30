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
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();

		}
		private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmCadastroUsuario form = new FrmCadastroUsuario();
			form.Show();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
            FrmLoginUsuario login = (FrmLoginUsuario)Application.OpenForms["FrmLoginUsuario"];
			login.Visible = true;
            this.Close();
		}

		public void usuárioToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			PesquisaUsuarios pesquisaUsuarios = new PesquisaUsuarios();
			pesquisaUsuarios.Show();
		}
	}
}
