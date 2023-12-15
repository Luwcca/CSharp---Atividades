using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{

    //Ela é um contrato onde quem assina se responsabiliza por implementar esses métodos (cumprir o contrato) 
    public interface IAutenticavel
    {
        bool Autenticar(string senha);

    }
}
