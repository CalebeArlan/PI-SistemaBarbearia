using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
	public class Horario
	{//id 	cod_cliente 	cod_servico 	hora 	data_horario 	
		public Horario(int idhorario, int codcliente, int codservico, string hora, string datahorario)
		{
			this.DataHorario = datahorario;
			this.IdHorario = idhorario;
			this.Hora = hora;
			this.CodCliente = codcliente;
			this.CodServico = codservico;
			
		}
		public int IdHorario;
		public int CodCliente;
		public int CodServico;
		public string Hora;
		public string DataHorario;
	}
}
