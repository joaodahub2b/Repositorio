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
        public int situacaoFuncionario { get; set; }

        public static int contadorCodigo = 1;

        public Funcionario() { }

        public Funcionario(string nome, string cpf, string dataNascimento, int tipoFuncionario)
        {
            this.configurarSalario(tipoFuncionario);
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.codigo = contadorCodigo;
            contadorCodigo++;
            this.tipoFuncionario = tipoFuncionario;
            this.situacaoFuncionario = 1;
        }

        public void configurarSalario(int tipoFuncionario)
        {
            if(tipoFuncionario == 1)
            {
                this.salario = 5000;
            }
            else if (tipoFuncionario == 2)
            {
                this.salario = 8000;
            }
            else if (tipoFuncionario == 3)
            {
                this.salario = 5500;
            }
            else if (tipoFuncionario == 4)
            {
                this.salario = 4500;
            }
            else if (tipoFuncionario == 5)
            {
                this.salario = 3000;
            }
        }
        public bool AlterarSalario(Funcionario f, double novoSalario)
        {
            f.salario = novoSalario;
            return true;
        }

        public void DesligarFuncionario(Funcionario f)
        {
            f.situacaoFuncionario = 0;
        }
    }
}
