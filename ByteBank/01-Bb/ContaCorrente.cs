//using _01_Bb; não é necessário pois compartilham o mesmo namespace

using System.Security.Cryptography;

namespace _01_Bb
{
    public class ContaCorrente
    {
        //public Cliente titular;
        public Cliente _titular = new Cliente();

        //torna a propriedade visivel em toda classe
        // torna o set privado 
        public static int TotalDeContas {  get; private set; }


        // O get e set pode estar vazio caso não haja nenhuma condição
        public Cliente Titular  
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }

        }

        //obriga a conta Corrente ter um numero de agencia e um numero, e ainda adiciona 1 conta no total
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContas++;
        }




        public int Agencia { get; set; }
        public int Numero { get; set; }
        //Saldo visivel somente na classe
        private double _saldo = 100;

        public double Saldo
        {
            get // retorna valor
            {
                //retorna a variavel saldo
                return _saldo;
            }
            set //atribui valor
            {
                // value = saldo
                if (value < 0)
                {
                    return;
                }
                else
                {
                    this._saldo = value;
                }
            }
        }


        public bool Sacar(double valor)
        {
            // o this serve para se referenciar a classe que atual
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }

        }


        public void Depositar(double valor)
        {

            // valido sem o this. pois não existe outra variavel ou argumento com o nome saldo
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente ContaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                ContaDestino.Depositar(valor);
                return true;
            }

        }

    }


}


