using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string nome, string cpf) : base(nome, cpf, 4000)
        {
            Console.WriteLine("Criando Gerente de Conta");
        }

        public override void AumentarSalario() => Salario *= 1.05;
        public override double GetBonificacao() => Salario *= 0.25;

    }
}
