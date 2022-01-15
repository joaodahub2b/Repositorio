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
            Funcionario funcionarioModelo = new Funcionario();

            while (option != 4)
            {
                //Conversa com o Sistema

                Console.WriteLine("*** Bem Vindo ao Byte Bank ***");
                Console.WriteLine("---\nEscolha Uma das Opções a baixo:");
                Console.WriteLine("1. Gerenciar Funcionário");
                Console.WriteLine("2. Alterar Salário");
                Console.WriteLine("3. Visualizar Funcionário");
                Console.WriteLine("4. Fechar Programa");
                option = int.Parse(Console.ReadLine());
                verificaOpcao(option, 4);

                if (option == 1)
                {

                    Console.WriteLine("---\nBem Vindo ao Módulo de Gerenciamento de Funcionários");
                    Console.WriteLine("1. Criar Funcionário");
                    Console.WriteLine("2. Desligar Funcionário");
                    option = int.Parse(Console.ReadLine());
                    verificaOpcao(option, 2);

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
                        Funcionario funcionario = new Funcionario(nomeFuncionario, cpfFuncionario, nascimentoFuncionario, option);
                        quadroDeFuncionarios.AdicionarFuncionario(funcionario);
                    }

                    if (option == 2)
                    {
                        Console.WriteLine("Digite o código do Funcionário que será desligado:");
                        codigoFuncionario = int.Parse(Console.ReadLine());
                        try
                        {
                            funcionarioModelo = quadroDeFuncionarios.LocalizarFuncionario(codigoFuncionario);
                            quadroDeFuncionarios.DesligarFuncionario(funcionarioModelo);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("Argumento não encontrado" + e.ParamName);
                            Console.WriteLine(e.Message);
                        }
                    }   
                }
                else if (option == 2)
                {
                    Console.WriteLine("Digite o Código do Funcionário que deseja Alterar o Salário: ");
                    codigoFuncionario = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o novo Salário desse Funcionário: ");
                    salario = double.Parse(Console.ReadLine());
                    try
                    {
                        funcionarioModelo = quadroDeFuncionarios.LocalizarFuncionario(codigoFuncionario);
                    }
                    catch(ArgumentException e)
                    {
                        Console.WriteLine("Argumento não encontrado" + e.ParamName);
                        Console.WriteLine(e.Message);
                    }
                    try
                    {
                        quadroDeFuncionarios.AlterarSalario(funcionarioModelo, salario);
                    }
                    catch(ArgumentException e)
                    {
                        Console.WriteLine("Argumento menor ou igual a zero" + e.ParamName);
                        Console.WriteLine(e.Message);
                    }
                }
                else if(option == 3)
                {
                    Console.WriteLine("Digite o código do Funcionário que deseja visualizar: ");
                    codigoFuncionario = int.Parse(Console.ReadLine());
                    quadroDeFuncionarios.MostrarFuncionario(codigoFuncionario);
                }
            }
        }

        static bool verificaOpcao(int opcao, int numOpcao)
        {
            try
            {
                if (opcao < 1 || opcao > numOpcao)
                {
                    throw new ArgumentException("Opcao inválida: " + nameof(opcao));
                }
                return true;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Tente Novamente");
                return false;
            }
        }
    }
}
