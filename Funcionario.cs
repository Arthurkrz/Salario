using System;

namespace Salario
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;
        public double CalcularSalarioLiquido()
        {
            return Salario - (Salario * Imposto / 100);
        }
        public void AumentarSalario(double incremento)
        {
            Salario += Salario * incremento / 100;
        }
    }
}
