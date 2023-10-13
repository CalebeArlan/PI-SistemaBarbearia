using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Cliente
    {
        public Cliente(int idcliente, string nomecliente, string telefonecliente, string emailcliente, int nasccliente, string cpfcliente, string rgcliente)
        {
            IdCliente = idcliente;
            NomeCliente = nomecliente;
            TelefoneCliente = telefonecliente;
            EmailCliente = emailcliente;
            DataNascCliente = nasccliente;
            CPFCliente = cpfcliente;
            RGCliente = rgcliente;
            
        }
        public int IdCliente;
        public string NomeCliente;
        public string TelefoneCliente;
        public string EmailCliente;
        public int DataNascCliente;
        public string CPFCliente;
        public string RGCliente;

    }
}
