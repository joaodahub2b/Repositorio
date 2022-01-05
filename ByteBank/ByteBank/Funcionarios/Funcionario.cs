using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {
        public int codigo { get; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string dataNascimento { get; set; }
        public double salario { get; set; }
        public int tipoFuncionario { get; set; }
        public static int contadorCodigo = 1;
        public Funcionario(string nome, string cpf, string dataNascimento, double salario)
        {
            this.salario = salario;
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.codigo = 1;
            contadorCodigo++;
        }

        public bool AlterarSalario(Funcionario f, double novoSalario)
        {
            f.salario = novoSalario;
            Console.WriteLine("Sucesso");
            return true;
        }
    }
}
