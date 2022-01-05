using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// O namespace determina da onde o nosso 'Cliente' está saindo
namespace _07_ByteBank
{
    public class Cliente
    {
        // Usar prop + tab + tab para criarmos atributos com getter e setter
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

    }
}
