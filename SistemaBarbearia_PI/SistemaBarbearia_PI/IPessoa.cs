﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia_PI
{
    public interface IPessoa
    {
        string Nome { get; set; }
        string CPF { get; set; }
        string RG { get; set; }
        string Telefone { get; set; }
    }
}
