using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // tornar a classe abstrata, impede de criar uma instancia Funcionaria, porém permite criar qualquer classe baseada nela
    public abstract class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }

      
        public string Nome { get; set; }
        public string CPF { get;private set;}

        //protrected é um tipo de private visivel às classes herdadas
        public double Salario { get; protected set; }



        public Funcionario(double salario,string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        //A parte abstract obriga a existir e sobrescrever o metodo 
        // metodos abstratos só existem as classes abstratas
        public abstract void AumentarSalario();



        // virtual mostra que o metodo pode ser sobrescrito por classes herdadas
        public abstract double GetBonificacao();


    }
}
