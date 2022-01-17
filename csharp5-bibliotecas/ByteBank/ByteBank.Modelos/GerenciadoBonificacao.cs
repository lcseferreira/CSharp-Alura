using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Modelos
{
    public class GerenciadoBonificacao
    {

        private double TotalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.GetBonificacao();
        }

        public double RetornaTotalBonificacao()
        {
            return TotalBonificacao;
        }
    }
}
