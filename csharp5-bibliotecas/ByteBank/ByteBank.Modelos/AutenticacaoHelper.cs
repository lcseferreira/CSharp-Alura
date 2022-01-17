using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    // Modificador de acesso padrão: internal
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
