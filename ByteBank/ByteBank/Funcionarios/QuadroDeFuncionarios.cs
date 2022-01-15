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
        Funcionario funcionarioVazio = new Funcionario();

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            listaDeFuncionarios.Add(funcionario);
        }

        public Funcionario LocalizarFuncionario(int codigoFuncionario)
        {
            foreach (Funcionario f in listaDeFuncionarios)
            {
                if (f.codigo == codigoFuncionario)
                { 
                    return f;
                }
            }
            return funcionarioVazio;
        }

        public void DesligarFuncionario(Funcionario f)
        {
            f.situacaoFuncionario = 0;
        }

        public void AlterarSalario(Funcionario f, double salario)
        {
            f.salario = salario;
        }
        public void MostrarFuncionario(int codigo)
        {
            foreach(Funcionario f in listaDeFuncionarios)
            {
                if(f.codigo == codigo)
                {
                    Console.WriteLine("Nome: " + f.nome);
                    Console.WriteLine("CPF: " + f.cpf);
                    Console.WriteLine("Data de Nascimento: " + f.dataNascimento);
                    Console.WriteLine("Salario: " + f.salario);
                    Console.WriteLine("Situação do Funcionário: " + f.situacaoFuncionario);
                }
            }
        }
    }
}
