using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DataPagamento = new DateTime(2002, 11, 23);

            DateTime DataCorrente = DateTime.Now;

            TimeSpan TempoFaltante = DataCorrente - DataPagamento;

            Console.WriteLine(DataPagamento);
            Console.WriteLine(DataCorrente);
            //Biblioteca baixada na parte ferramentas>Grenciador dos pacotes NuGet> Console
            Console.WriteLine("Se passaram " + TimeSpanHumanizeExtensions.Humanize(TempoFaltante));


            Console.ReadLine();
        }

       
    }
}
