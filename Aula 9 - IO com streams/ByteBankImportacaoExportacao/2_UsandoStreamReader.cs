using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;// biblioteca do FileStream
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void PartialStreamReader()
        {

            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            //faz leitura da stream sem necessidade de manipular os bytes
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {

                //EndOfStream verifica se chegou no final
                while (!leitor.EndOfStream)
                {
                    //.ReadToEnd - lê até o fim
                    //.Read - lê o primeiro byte
                    var linha = leitor.ReadLine();

                    var contaCorrente = ConverterStringParaContaCorrente(linha);


                    var msg = $"{contaCorrente.Titular.Nome} : Conta número {contaCorrente.Numero}, ag. {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo}";
                    Console.WriteLine(msg);


                    //Console.WriteLine(linha);
                }

            }



            Console.ReadLine();
        }


        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            //separa em array de sting
            var campos = linha.Split(',');
            var agencia = campos[0];
            var numeros = campos[1];
            var saldo = campos[2].Replace(".", ",");
            var nome = campos[3];

            //int.Parse tranforma a string em int

            var agenciaInt = int.Parse(agencia);
            var numerosInt = int.Parse(numeros);

            var saldoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nome;

            var resultado = new ContaCorrente(agenciaInt, numerosInt);
            resultado.Depositar(saldoDouble);
            resultado.Titular = titular;

            return resultado;
        }



    }
}
