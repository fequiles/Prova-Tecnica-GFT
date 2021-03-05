using System;
class Investimento{
    protected float _valorInicial;
    protected double _jurosMensais;
    public Investimento(float valor, double juros){
         this._valorInicial = valor;
         this._jurosMensais = juros;
    }

    public virtual double CalculaLucro(int meses)
    {
        double retorno;
        double jurosPlusOne = (this._jurosMensais/100) + 1;
        double jurosFinal = 1;

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