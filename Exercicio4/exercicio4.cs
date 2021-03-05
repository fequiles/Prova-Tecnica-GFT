using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumero;
            int numero;
            bool condicao = true;
            int soma = 0;

            while (condicao == true){
                Console.WriteLine("Digite um numero:");
                stringNumero = Console.ReadLine();

                numero = Int32.Parse(stringNumero);

                if (numero >= 0)
                {
                    soma += numero;
                    if (soma >= 157)
                    {
                        Console.WriteLine("O Somatório foi de: " + soma);
                        condicao = false;
                    }
                }
                else 
                    Console.WriteLine("Números negativos nao sao permitidos");
            }
        }
    }
}
