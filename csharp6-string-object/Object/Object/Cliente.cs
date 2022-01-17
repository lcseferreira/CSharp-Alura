using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public int Idade { get; set; }

        public Cliente(string nome, string cfp, int idade)
        {
            Nome = nome;
            Idade = idade;
            CPF = cfp;
        }

        public override bool Equals(object? obj)
        {
            // Conversão que retorna null se o obj não for um Cliente
            Cliente objCliente = obj as Cliente;

            if (objCliente == null) return false;

            return CPF == objCliente.CPF;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return $"Nome: {this.Nome}, Idade {this.Idade}";
        }
    }
}
