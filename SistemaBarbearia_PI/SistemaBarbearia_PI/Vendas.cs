using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Vendas
    {
        
        public Vendas(int idvenda, int codhora, int codfunc, double valor)
        {
            IdVendas = idvenda;
            CodHorario = codhora;
            CodFuncionario = codfunc;
            ValorVenda = valor;
        }
        public int IdVendas;
        public int CodHorario;
        public int CodFuncionario;
        public double ValorVenda;
    }
}
