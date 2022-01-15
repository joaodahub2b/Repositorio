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
            throw new ArgumentException("O valor " + nameof(codigoFuncionario) + " não foi localizado");
        }

        public void DesligarFuncionario(Funcionario f)
        {
            f.situacaoFuncionario = 0;
        }

        public void AlterarSalario(Funcionario f, double salario)
        {
            if(salario <= 0)
            {
                throw new ArgumentException("O valor do " + nameof(salario) + " não pode ser menor ou igual a zero");
            }
            f.salario = salario;
        }
        public void MostrarFuncionario(int codigo)
        {
            try
            {
                Funcionario f = LocalizarFuncionario(codigo);
                Console.WriteLine("Nome: " + f.nome);
                Console.WriteLine("CPF: " + f.cpf);
                Console.WriteLine("Data de Nascimento: " + f.dataNascimento);
                Console.WriteLine("Salario: " + f.salario);
                Console.WriteLine("Situação do Funcionário: " + f.situacaoFuncionario);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
