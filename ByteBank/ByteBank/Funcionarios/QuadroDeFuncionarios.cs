using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class QuadroDeFuncionarios
    {
        List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            listaDeFuncionarios.Add(funcionario);
        }

        public void MostrarFuncionario()
        {
            foreach(Funcionario f in listaDeFuncionarios)
            {
                Console.WriteLine("Código: " + f.codigo);
                Console.WriteLine("Nome: " + f.nome);
                Console.WriteLine("CPF: " + f.cpf);
                Console.WriteLine("Data de Nascimento: " + f.dataNascimento);
                Console.WriteLine("Salario: " + f.salario);
            }
        }

        public bool LocalizaCodAlterarSalario(int codigoFuncionario, double novoSalario)
        {
            Console.WriteLine("teste");
            foreach (Funcionario f in listaDeFuncionarios)
            {
                Console.WriteLine("teste");
                if (f.codigo == codigoFuncionario)
                {
                    f.AlterarSalario(f, novoSalario);
                }
            }
            return true;
        }
    }
}
