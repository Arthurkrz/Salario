using System;

namespace Salario
{
    public class AumentarSalario
    {
        public static void IncrementoSalario(Dados dados)
        {
            Console.WriteLine("Qual o valor em % a ser adicionado ao salário?");
            double incremento = double.Parse(Console.ReadLine());
            double valorincremento = dados.salariobruto * (incremento / 100);
            dados.salariobruto += valorincremento;
            double imposto2 = dados.imposto / 100;
            dados.salarioliquido = dados.salariobruto - (dados.salariobruto * imposto2);
            Console.WriteLine($"{dados.nome} agora ganha R${dados.salarioliquido} por mês.");
        }
    }
}