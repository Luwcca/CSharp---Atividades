using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var idades = new List<int>();
            idades.Add(5);
            idades.Add(6);
            idades.AddRange(new int[] { 1, 2, 3, 4, 5, });
            idades.Remove(5);
            //ListExtensoes<int>.AdicionarVarios(idades, 10, 11, 13);
            //possivel por conta do metodo de extenção

            
            idades.AdicionarVarios(15, 30, -1);
            //Sort para oredenar
            idades.Sort();



            for (int i = 0; i < idades.Count; i++)
            {
                int idadeAtual = idades[i];
                Console.WriteLine(idadeAtual);
            }


            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 1),
                new ContaCorrente(342, 45678),
                null,
                new ContaCorrente(340, 3),
                null,
                new ContaCorrente(290, 18950)
            };


            //contas.Sort(); ~~> chama a implementação dada em IComparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());




            //expressão lambda (conta => conta != null) retorna um bool se não for null, where filtra
            // IEnumerable < ContaCorrente >pode ser var
            //IEnumerable< ContaCorrente > contasSemNull = contas.Where(conta => conta != null);




            //retorna um valor tipo conta corrente a partir do orderby utilizando uma expressão lambda
            // IOrderedEnumerable<ContaCorrente> pode ser mudado para var
            //IOrderedEnumerable<ContaCorrente> contasOrdenada =
            //    contasSemNull.OrderBy(conta => conta.Numero);


            //resumindo temos:

            var contasOrdenada = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);


            foreach (var conta in contasOrdenada)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
                
            }










            Console.ReadLine();
        }

        static void TesteVar()
        {
            //o var altera o tipo para o mesmo da atribuição 
            // mesma coisa que escrever  ContaCorrente conta = new ContaCorrente(344, 56456556);
            var conta = new ContaCorrente(344, 56456556);
            var gerenciador = new GerenciadorBonificacao();
            var gerenciadores = new List<GerenciadorBonificacao>();
        }

        static void TestList()
        {
            
        }

    }
}
