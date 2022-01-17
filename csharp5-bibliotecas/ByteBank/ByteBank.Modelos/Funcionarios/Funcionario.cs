using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        // Atributos da classe
        public string Nome { get; set; }
        public double Salario { get; protected set; }

        // O CPF só pode ser modificado dentro da classe - private set;
        public string CPF { get; private set; }

        // ATRIBUTO ESTÁTICO - atributo da classe
        public static int TotalDeFuncionarios { get; private set; }

        // CONSTRUTORES
        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome; ;
            CPF = cpf;
            Salario = salario;

            Console.WriteLine("Criando Funcionário");
            TotalDeFuncionarios++;
        }

        // SOBRECARGA DE CONSTRUTOR passando o construtor de cima para atribuir um valor padrão
        public Funcionario(string nome, string cpf) : this(nome, cpf, 1500) { }

        // MÉTODOS ABSTRATOS: esses métodos precisam ser implementados OBRIGATORIAMENTE pelas classes derivadas
        // Métodos abstratos só podem fazer parte de Classes abstratas
        public abstract void AumentarSalario();

        // LAMBDA
        // virtual: pode ser reescrito
        public virtual double GetBonificacao() => Salario * 0.1;

    }
}
