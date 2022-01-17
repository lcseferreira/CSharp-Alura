using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class ExtratorArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorArgumentosURL(string url)
        {


            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException(nameof(url));
            }

            URL = url;

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao++);
        }

        // moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {

            // Deixando um padrão para as strings em minúsculo
            nomeParametro = nomeParametro.ToLower();
            string argumentoLower = _argumentos.ToLower();

            // Pegando o termo que iremos utilizar
            string termo = nomeParametro.ToLower() + "=";

            // Pegando o índice do termo na string
            int indiceTermo = argumentoLower.ToLower().IndexOf(termo);

            // O resultado é o valor do parametro passado
            string resultado = _argumentos.Substring(indiceTermo + termo.Length);

            // O & será examinado para caso o nosso parâmetro procurado não seja o último
            int indiceSeparadorArgumento = resultado.IndexOf('&');


            if (indiceSeparadorArgumento == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceSeparadorArgumento);
        }
    }
}
