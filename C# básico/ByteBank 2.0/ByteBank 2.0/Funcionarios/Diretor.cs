using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // Herda as caracteristicas da classe Funcionario
    public class Diretor : FuncionarioAutenticavel
    {
        // pode sobrescrever o metodo virtual
        public override double GetBonificacao()
        {
            //base. pega membros declarados na classe base
            return Salario*0.5;
        }


        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }



        //A classe também herda os contrutores, somando mais uma vez O total de funcionarios
        //Adicionado o argumento herdando o argumento do construtor da base
        // fixa o salario de 5000 para os diretores e só passa como argumento o cpf
        public Diretor(string cpf) : base(5000, cpf) { }







    }
}
