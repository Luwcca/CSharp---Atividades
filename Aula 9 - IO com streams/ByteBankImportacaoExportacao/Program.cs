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
        static void Main(string[] args)
        {

            //podemos facilitar o uso da leitura e escrita em arquivos usando a classe File.
            //Teste Escrita
            File.WriteAllText("escrevendoComAClasseFile.txt", "tentando file");
            Console.WriteLine("Arquivo criado!");

            //Teste Leitura de byte
            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine(bytesArquivo.Length);

            //Teste leitura string
            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var line in linhas)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();

            //Podemos usar o ReadLine para coletar informaçoes da console
            var nome = Console.ReadLine();
            Console.WriteLine(nome);
            Console.ReadLine();
        }


    }
} 
 