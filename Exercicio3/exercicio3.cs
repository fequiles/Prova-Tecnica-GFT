using System;

namespace Exercicio3
{
    class Program
    {
        static public bool VerificaIntervalo(int intervaloInicial, int intervaloFinal)
        {
            int subtracao;

            subtracao = intervaloFinal -  intervaloInicial;

            if (intervaloInicial >= intervaloFinal)
            {
                Console.WriteLine("Erro: O intervalo inicial deve ser menor que o final");
                return false;
            }
            if (subtracao >= 10)
            {
                Console.WriteLine("Erro: A diferenca entre os intervalos deve ser menor que 10");
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int multiplicando, inicio, fim, result;

            Console.WriteLine("Multiplicando:");
            multiplicando = Int32.Parse(Console.ReadLine());

            if ((multiplicando < 0) || (multiplicando > 5000))
            {
                Console.WriteLine("Erro: o multiplicando x deve atender 0 <= x <= 5000");
                return;
            }

            Console.WriteLine("Inicio do intervalo:");
            inicio = Int32.Parse(Console.ReadLine());

            if ((inicio < 0) || (inicio > 5000))
            {
                Console.WriteLine("Erro: o interval de inicio x deve atender 0 <= x <= 5000");
                return;
            }

            Console.WriteLine("Fim do intervalo:");
            fim = Int32.Parse(Console.ReadLine());

            if ((inicio < 0) || (inicio > 5000))
            {
                Console.WriteLine("Erro: o intervalo de fim x deve atender 0 <= x <= 5000");
                return;
            }

            if (VerificaIntervalo(inicio, fim))
            {
                for (int i = inicio; i <= fim; i++)
                {
                    result = multiplicando * i;
                    Console.WriteLine(multiplicando + " x " + i + " = " + result);  
                }
            }

        }
    }
}
