using System;

class InvestimentoSemIR : Investimento
{
    public InvestimentoSemIR(float valor, double juros): base(valor, juros)
    {}

    public override double CalculaLucro(int meses)
    {
        double retorno;
        double jurosPlusOne = (base._jurosMensais/100) + 1;
        double jurosFinal = 1;

        if (_valorInicial < 1000)
        {
            Console.WriteLine("O valor inicial não pode ser menor que R$1000");
            return 0;
        }

        if (meses <= 0)
        {
            Console.WriteLine("Erro: é necessario que os meses sejam >= 1");
            return 0;
        } 

        for (int i = 0; i <= meses; i++)
            jurosFinal *= jurosPlusOne;


        retorno = (base._valorInicial * jurosFinal) - base._valorInicial;

        return retorno;
    }
}