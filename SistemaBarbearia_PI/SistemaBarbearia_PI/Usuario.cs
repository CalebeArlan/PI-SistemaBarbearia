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
        public Usuario(int idusuario, string nomeusuario, string senha, string tipoacesso)
        {
            IdUsuario = idusuario;
            NomeUsuario = nomeusuario;
            Senha = senha;
            TipoAcesso = tipoacesso;
        }
        public int IdUsuario;
        public string NomeUsuario;
        public string Senha;
        public string TipoAcesso;
    }
}
