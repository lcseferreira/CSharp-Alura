using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // HERANÇA: o Diretor é um FuncionarioAutenticavel
    public class Diretor : FuncionarioAutenticavel
    {
        // Sobrescrita do construtor da classe base
        public Diretor(string nome, string cpf) : base(nome, cpf, 5000)
        {
            Console.WriteLine("Criando Diretor");
        }

        // Sobrescrita do método AumentarSalario da clase base
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        // 'Sobrescrita' do método GetBonificacao da classe base
        public override double GetBonificacao()
        {
            return Salario *= 0.5;
        }
    }
}
