using System;

namespace _01_Bb
{
    internal class Program
    {
        private static void Main(string[] args)
        {   
            Cliente cliente = new Cliente();
            ContaCorrente conta = new ContaCorrente(863,11111);

            

            ContaCorrente bruno = new ContaCorrente(01,2000);
            // instancia uma referencia de objeto no campo titular
            //bruno.titular = new Cliente(); caso a proriedade não ser inicializada dentro da classe

            


            cliente.Nome = "Gabriela";
            cliente.Profissao = "Dev";
            cliente.Cpf = "cpf";

            conta.Titular = cliente;

            bruno.Titular.Nome = "Bruno";

            conta.Saldo = 100;

            Console.WriteLine("Saldo da "+ conta.Titular.Nome +":" +conta.Saldo);

            conta.Sacar(50);

            Console.WriteLine(conta.Saldo);

            conta.Depositar(100);

            Console.WriteLine(conta.Saldo);

            conta.Transferir(100, bruno);

            Console.WriteLine("Dinheiro da " + conta.Titular.Nome + ": " + conta.Saldo + "\nDinheiro da " + bruno.Titular.Nome +": " + bruno.Saldo);
            Console.WriteLine("Total de Contas: " + ContaCorrente.TotalDeContas);
        }
    }
}