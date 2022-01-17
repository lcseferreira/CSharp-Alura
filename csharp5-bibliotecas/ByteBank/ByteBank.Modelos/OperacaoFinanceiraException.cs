﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(string message) : base(message)
        {

        }

        public OperacaoFinanceiraException(string message, Exception excecaoInterna) : base(message, excecaoInterna)
        {

        }
    }
}
