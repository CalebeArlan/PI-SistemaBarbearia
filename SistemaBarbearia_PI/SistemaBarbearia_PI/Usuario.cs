using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public class Usuario
    {
        public Usuario(string nomeusuario, string senha, string tipoacesso)
        {
            NomeUsuario = nomeusuario;
            Senha = senha;
            TipoAcesso = tipoacesso;
        }

        public string NomeUsuario;
        public string Senha;
        public string TipoAcesso;
    }
}
