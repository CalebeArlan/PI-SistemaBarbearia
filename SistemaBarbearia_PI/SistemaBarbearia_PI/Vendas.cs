using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Vendas : Base
    {
        
        public Vendas(int idvenda, int codhora, int codfunc, double valor, string horavenda, string datavenda )
        {
            Id = idvenda;
            CodHorario = codhora;
            CodFuncionario = codfunc;
            ValorVenda = valor;
            HoraVenda = horavenda;
            DataVenda = datavenda;
        }
        public int CodHorario;
        public int CodFuncionario;
        public double ValorVenda;
        public string HoraVenda;
        public string DataVenda;
    }
}
