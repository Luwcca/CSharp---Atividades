using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


            Funcionario carlos = new Funcionario("546.879.157-20");
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);


            Console.WriteLine(carlos.Nome);
            Console.WriteLine(roberta.Nome);



            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();


        }
    }
}