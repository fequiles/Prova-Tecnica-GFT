using System;

    class InvestimentoComIR : Investimento
    {
        public InvestimentoComIR( double juros): base( juros)
        {}

        public override double CalculaLucro(int meses)
        {
            double retorno;
            double jurosPlusOne = (this._jurosMensais/100) + 1;
            double jurosFinal = 1;

            if (meses <= 0)
            {
                Console.WriteLine("Erro: é necessario que os meses sejam >= 1");
                return 0;
            } 

            for (int i = 0; i < meses; i++)
                jurosFinal *= jurosPlusOne;


            retorno = (this._valorInicial * jurosFinal) - this._valorInicial;
            if (meses < 6)
                retorno *= 0.225;
            else if(meses < 12)
                retorno *= 0.2;
            else if(meses < 24)
                retorno *= 0.175;
            else 
                retorno *= 0.15;
            return retorno;
        }
    }
