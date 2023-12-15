using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;// biblioteca do FileStream
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    //partial separa as classes em vários arquivos
    partial class Program
    {
        static void LidadandoComStreamDiretamente()
        {
            //arquivo endereçado na pasta do executavel
            var enderecoDoArquivo = "contas.txt";

            //aponta o endereço e ação
            //using é similar ao try/finnaly - precisa do Idisposable, que existe no Stream
            // o using utiliza o metodo Dispose no final de sua aplicação
            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {


                var buffer = new byte[1024]; // 1kb
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);

                }


            }


          
        }


        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            //encoding versão utf8
            //var utf8 = Encoding.UTF8;
            //var utf8 = Encoding.Default;
            var utf8 = new UTF8Encoding();


            //utiliza a quantidade de byteslidos para trsformar em string
            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);



            //foreach (var b in buffer)
            //{
            //    Console.Write(b + " ");
            //}
        }

    }
}