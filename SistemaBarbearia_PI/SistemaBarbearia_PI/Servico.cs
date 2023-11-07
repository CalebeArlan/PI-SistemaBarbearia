using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
	public class Servico:Base
	{
		public Servico(int idservico, string nomeservico, double preco, string descricao)
		{
			this.Id = idservico;
			this.Nome = nomeservico;
			this.Preco = preco;
			this.Descricao = descricao;
		}
		public string Nome;
		public double Preco;
		public string Descricao;
	}
}
