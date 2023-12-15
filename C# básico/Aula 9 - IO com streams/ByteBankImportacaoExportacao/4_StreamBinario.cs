using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))//escreve em binário
            {
                escritor.Write(456);//número da Agência
                escritor.Write(546544);//número da conta
                escritor.Write(4000.50);//Saldo
                escritor.Write("Gustavo Braga");
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var escritor = new BinaryReader(fs))
            {
                var agencia = escritor.ReadInt32();
                var numeroConta = escritor.ReadInt32();
                var saldo = escritor.ReadDouble();
                var titular = escritor.ReadString();


                Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");

            }
        }

    }
}

