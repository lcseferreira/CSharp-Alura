using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoList
{
    // Extensões da classe List
    public static class ListExtension
    {
        // Método de extensão utilizando List com classe genérica
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach(T item in itens)
            {
                lista.Add(item);
            } 
        }
    }
}
