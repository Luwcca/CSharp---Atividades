using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // Herda as caracteristicas da classe Funcionario
    public class Diretor : Funcionario
    {
        // pode sobrescrever o metodo virtual
        public override double GetBonificacao()
        {
            //base. pega membros declarados na classe base
            return Salario + base.GetBonificacao();
        }


        //A classe também herda os contrutores, somando mais uma vez O total de funcionarios
        //Adicionado o argumento herdando o argumento do construtor da base
        public Diretor(string cpf) : base(cpf) { }


    }
}
