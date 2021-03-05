using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor;
            double lucroComIR, lucroSemIR;

            Console.WriteLine("Digite o valor:");
            valor = float.Parse(Console.ReadLine());

            InvestimentoComIR comIR = new InvestimentoComIR(1.2);
            InvestimentoSemIR semIR = new InvestimentoSemIR(0.7);

            comIR.setValor(valor);
            Console.WriteLine(valor);

            for (int i = 1; i < 36; i++)
            {
                lucroComIR = comIR.CalculaLucro(i);
                lucroSemIR = semIR.CalculaLucro(i);
                Console.WriteLine("Mês " + i + " | Investimento Sem IR: " + lucroSemIR + " | Investimento Com IR: " + lucroComIR);
            }

        }
    }
}
