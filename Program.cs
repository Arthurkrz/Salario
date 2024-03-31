using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Insira o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Insira o salário do funcionário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            if (funcionario.Imposto > 0 && funcionario.Salario > 0)
            {
                Console.WriteLine($"Funcionário {funcionario.Nome}.");
                double salarioLiquido = funcionario.CalcularSalarioLiquido();
                Console.WriteLine($"{funcionario.Nome} ganha R${salarioLiquido} por mês.");
                Console.WriteLine("Qual o valor em % a ser adicionado ao salário?");
                double valorIncremento = double.Parse(Console.ReadLine());
                funcionario.AumentarSalario(valorIncremento);
                salarioLiquido = funcionario.CalcularSalarioLiquido();
                Console.WriteLine($"{funcionario.Nome} agora ganha R${salarioLiquido} por mês.");
            }
        }
    }
}