using System;

namespace Salario
{
    public class CalculadoraSalarioLiquido
    {
        public static double CalcularSalarioLiquido(Dados dados)
        {
            double imposto2 = dados.imposto / 100;
            dados.salarioliquido = dados.salariobruto - (dados.salariobruto * imposto2);
            return dados.salarioliquido;
        }
    }
}
