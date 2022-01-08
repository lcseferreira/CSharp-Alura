using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // Herança: todo Designer É um Funcionário
    public class Designer : Funcionario
    {
        // Construtor
        public Designer(string nome, string cpf) : base(nome, cpf, 3000)
        {
            Console.WriteLine("Criando Designer");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.17;
        }
    }
}
