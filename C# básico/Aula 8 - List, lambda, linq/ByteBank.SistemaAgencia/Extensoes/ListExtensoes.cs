using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    //static pois não prcisa ser instanciada

    public static class ListExtensoes
    {
        // o this utilizado no argumento de uma classe serve como uma extenção
        // nesse caso o this não é utilizado, pois o metodo de extensão deve ser definido em uma classe estática não genérica
        //desse modo, ao colocarmos apenas o metodo como genérico, funciona
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
            {
            foreach (T item in itens)
            {
                lista.Add(item);
            }

        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            //ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4);
        }

    }
}
