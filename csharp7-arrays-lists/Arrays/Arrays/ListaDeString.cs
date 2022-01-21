using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ListaDeString
    {
        private string[] _itens;
        private int _proximoIndex;

        public int Tamanho
        {
            get
            {
                return _proximoIndex;
            }
        }

        public ListaDeString()
        {
            _itens = new string[5];
            _proximoIndex = 0;
        }

        public void EscreveLista()
        {
            foreach (var item in _itens)
            {
                Console.WriteLine(item);
            }
        }

        // Parâmetros opcionais
        public void TesteParam(string opcional1 = "Textinho", int opcional2 = 7)
        {
            Console.WriteLine(opcional1);
            Console.WriteLine(opcional2);
        }

        public void Adicionar(string str)
        {
            VerificarCapacidade(_proximoIndex + 1);

            Console.WriteLine($"Adicionando item na posição {_proximoIndex}");

            _itens[_proximoIndex] = str;
            _proximoIndex++;
        }

        // Método passando array ou várias contas
        public void AdicionarVarios(params string[] strs)
        {
            foreach (var str in strs)
            {
                VerificarCapacidade(_proximoIndex + 1);
                _itens[_proximoIndex] = str;
                _proximoIndex++;
            }
        }

        public void Remover(int index)
        {

            if (_itens[index] == null) return;

            // Nunca iremos chegar na última posição = i < _proximoIndex
            for (int i = index; i < _proximoIndex - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximoIndex--;
            _itens[_proximoIndex] = null;

            return;
        }

        private void VerificarCapacidade(int tamanho)
        {
            if (_itens.Length >= tamanho) return;

            Console.WriteLine("Aumentando capacidade");

            string[] novoArray = new string[tamanho];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }

        public string GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximoIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        // Propriedade para recuperar pelo índice
        public string this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
    }
}
