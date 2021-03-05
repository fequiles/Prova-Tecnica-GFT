using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            InvestimentoComIR comIR = new InvestimentoComIR(5000, 1.2);
            InvestimentoSemIR semIR = new InvestimentoSemIR(3000, 0.7);
            double lucroComIR, lucroSemIR;

            lucroComIR = comIR.CalculaLucro(17);
            lucroSemIR = semIR.CalculaLucro(10);

            Console.WriteLine("O lucro do investimento com IR é de: " + lucroComIR);
            Console.WriteLine("O lucro do investimento sem IR é de: " + lucroSemIR);
        }
    }
}
