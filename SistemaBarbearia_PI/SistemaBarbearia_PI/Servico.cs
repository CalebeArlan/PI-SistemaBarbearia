using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
	public class Servico
	{
		public Servico(int idservico, string nomeservico, double preco, string descricao)
		{
			this.IdServico = idservico;
			this.NomeServico = nomeservico;
			this.Preco = preco;
			this.Descricao = descricao;
		}
		public int IdServico;
		public string NomeServico;
		public double Preco;
		public string Descricao;
	}
}
