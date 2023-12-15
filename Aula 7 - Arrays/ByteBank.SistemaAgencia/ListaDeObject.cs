using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeObject
    {
        private object[] _itens;
        private int _proximaPosicao;

        public ListaDeObject(int capacidadeInicial = 5)
        {
            _itens = new object[capacidadeInicial];
            _proximaPosicao = 0;
        }

        //é possivel criar argumentos opcionais ao atribuir um valor padrão
        public void MeuMetodo(string texto = "texti padrao", int numero = 5)
        {

        }

        public void Adicionar(object item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }


        //params transforma o argumento em array
        public void AdicionarVarios(params object[] itens)
        {
            // funciona igual um for(int i = 0; i < itens.Length; i++)
            foreach (object item in itens)
            {
                Adicionar(item);
            }
        }




        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            //Console.WriteLine("Aumentando capacidade da lista!");

            object[] novoArray = new object[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                //Console.WriteLine(".");
            }

            _itens = novoArray;

        }

 




        public void Remover(object item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {

                object itemAtual = _itens[i];


                //Equals compara objetos, == compara a referencia na memória
                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }



            }

            for (int i = indiceItem; i < _proximaPosicao; i++)
            {
                _itens[i] = _itens[i + 1];
            }


            _proximaPosicao--;
            _itens[_proximaPosicao] = null;

        }

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public object GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }


        //indexador criado, troca o lista.GetItenNoIndice(i) para lista[i];
        public object this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }

        }


    }
}
