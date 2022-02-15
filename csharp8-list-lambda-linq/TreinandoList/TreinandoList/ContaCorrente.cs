using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoList
{
    public class ContaCorrente : IComparable
    {
        public int Numero { get; private set; }
        public int Agencia { get; private set; }

        public ContaCorrente(int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;
        }

        public int CompareTo(object? obj)
        {
            // Retornar negativo quando a instância precede o obj
            // Retornar 0 quando a instância e o obj for equivalente
            // Retornar positivo quando a precedência for de obj

            // Convertendo o obj
            var outraConta = obj as ContaCorrente;

            if (outraConta == null) { return -1; }

            if (Numero < outraConta.Numero) { return -1; }
            if (Numero > outraConta.Numero) { return 1; }
            
            return 0;
        }
    }
}
