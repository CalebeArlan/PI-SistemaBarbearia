using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Funcionario : IPessoa
    {
        public Funcionario(int idfuncionario, string nomefuncionario, string nascfuncionario, string telefone, string cpffuncionario, string rgfuncionario, string enderecofuncionario, string codcargo, string emailfuncionario)
        {
            Id = idfuncionario;
            Nome = nomefuncionario;
            DataNasc = nascfuncionario;
            Telefone = telefone;
            CPF = cpffuncionario;
            RG = rgfuncionario;
            Endereco = enderecofuncionario;
            Cargo = codcargo;
            Email = emailfuncionario;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
		public string DataNasc { get; set; }
        public string Telefone { get; set; }
		public string CPF { get; set; }
		public string RG { get; set; }
		public string Endereco { get; set; }
		public string Cargo { get; set; }
		public string Email { get; set; }
	}
}
