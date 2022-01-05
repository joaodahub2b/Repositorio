using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            int option = 0;
            int codigoFuncionario = 0;
            string nomeFuncionario = "";
            string cpfFuncionario = "";
            string nascimentoFuncionario = "";
            double salario = 0.0;
            QuadroDeFuncionarios quadroDeFuncionarios = new QuadroDeFuncionarios();


            while (option != 7)
            {
                //Conversa com o Sistema
                Console.WriteLine("*** Bem Vindo ao Byte Bank ***");
                Console.WriteLine("---\nEscolha Uma das Opções a baixo:");
                Console.WriteLine("1. Adicionar Funcionário");
                Console.WriteLine("2. Alterar Salário");
                Console.WriteLine("7. Fechar Programa");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("\n---\nDigite o Cargo do novo Funcionário:");
                    Console.WriteLine("1. Gerente De Contas\n2. Diretor\n3. Desenvolvedor\n4. Designer\n5. Auxiliar");
                    option = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Nome do novo Funcionário: ");
                    nomeFuncionario = Console.ReadLine();
                    Console.WriteLine("Digite o CPF do novo Funcionário: ");
                    cpfFuncionario = Console.ReadLine();
                    Console.WriteLine("Digite a Data de Nascimento do novo Funcionário: ");
                    nascimentoFuncionario = Console.ReadLine();
                    Funcionario funcionario = new Funcionario(nomeFuncionario, cpfFuncionario, nascimentoFuncionario, 4500.0);
                    Console.WriteLine("Teste: " + funcionario.codigo);
                    quadroDeFuncionarios.AdicionarFuncionario(funcionario);
                    Console.WriteLine("Teste: "+ funcionario.codigo);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Digite o Código do Funcionário que deseja Alterar o Salário: ");
                    codigoFuncionario = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o novo Salário desse Funcionário: ");
                    salario = double.Parse(Console.ReadLine());
                    quadroDeFuncionarios.LocalizaCodAlterarSalario(codigoFuncionario, salario);

                    Console.WriteLine("Sucesso");
                }
                
            }
            

        }
    }
}
