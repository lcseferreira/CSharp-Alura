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
        // Método de extensão
        public static void AdicionarVarios(this List<int> lista, params int[] itens)
        {
            foreach(var item in itens)
            {
                lista.Add(item);
            } 
        }
    }
}
