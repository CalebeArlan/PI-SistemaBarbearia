using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Funcionario
    {
        public Funcionario(int idfuncionario, string nomefuncionario, string nascfuncionario, string cpffuncionario, string rgfuncionario, string enderecofuncionario, int codcargo, string emailfuncionario)
        {
            IdFuncionario = idfuncionario;
            NomeFuncionario = nomefuncionario;
            DataNascFuncionario = nascfuncionario;
            CPFFuncionario = cpffuncionario;
            RGFuncionario = rgfuncionario;
            EnderecoFuncionario = enderecofuncionario;
            CodCargo = codcargo;
            EmailFuncionario = emailfuncionario;
        }
        public int IdFuncionario;
        public string NomeFuncionario;
        public string DataNascFuncionario;
        public string CPFFuncionario;
        public string RGFuncionario;
        public string EnderecoFuncionario;
        public int CodCargo;
        public string EmailFuncionario;
    }
}
