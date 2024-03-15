using System;

namespace SalarioSOO
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salariobruto;
            double salarioliquido;
            double imposto;
            double incremento;
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Insira o nome do funcionário: ");
                nome = Console.ReadLine();
                Console.WriteLine("Insira o salário do funcionário: ");
                salariobruto = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira o valor do imposto: ");
                imposto = double.Parse(Console.ReadLine());
                if (imposto > 0 && salariobruto > 0)
                {
                    double imposto2 = imposto / 100;
                    Console.WriteLine($"Funcionário {nome}.");
                    salarioliquido = salariobruto - (salariobruto * imposto2);
                    Console.WriteLine($"{nome} ganha R${salarioliquido} por mês.");
                    Console.WriteLine("Qual o valor em % a ser adicionado ao salário?");
                    incremento = double.Parse(Console.ReadLine());
                    double valorincremento = salariobruto * (incremento / 100);
                    salariobruto += valorincremento;
                    double imposto3 = imposto / 100;
                    salarioliquido = salariobruto - (salariobruto * imposto3);
                    Console.WriteLine($"{nome} agora ganha R${salarioliquido} por mês.");
                    controle = false;
                }
            }
        }
    }
}