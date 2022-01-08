﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    // INTERFACE
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}