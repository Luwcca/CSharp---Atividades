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
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoSting = "456,7895,4785.40, Gustavo Santos";
                var encoding = Encoding.UTF8;
                
                //tranforma uma String in byte[]
                var bytes = encoding.GetBytes(contaComoSting);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }

        }
        
        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            //CreateNew lança uma exeção se existir o arquivo, o Create só substitui
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo,Encoding.UTF8))
            {
                escritor.Write("456,65465,456.0,Pedro");
            }
         

        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 1000000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush();//Despeja o buffer na stream, ao invés de deixar o buffer ficar cheio

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }
            }
        }





    }
}
