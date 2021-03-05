using System;

class InvestimentoSemIR : Investimento
{
    public InvestimentoSemIR( double juros): base( juros)
    {}

    public override double CalculaLucro(int meses)
    {
        double retorno;
        double jurosPlusOne = (this._jurosMensais/100) + 1;
        double jurosFinal = 1;

        if (this._valorInicial < 1000)
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


        retorno = (this._valorInicial * jurosFinal) - this._valorInicial;

        return retorno;
    }
}