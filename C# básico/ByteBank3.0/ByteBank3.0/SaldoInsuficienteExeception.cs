using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank3._0
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        //cria construtor sem parametros
        public SaldoInsuficienteException()
        {

        }


        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            ///manda a string para com o this, para o construtor que usa a string
            : this("Tentativa de saque no valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        


        //cria construtor com parametro de string
        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {

        }

        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {
        }

    }
}
