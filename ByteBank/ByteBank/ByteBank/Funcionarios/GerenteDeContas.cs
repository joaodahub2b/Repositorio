using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string nome, string cpf, string dataNascimento) : base (nome, cpf, dataNascimento, 4500.0)
        {
            
        }
    }
}
