using System;
using Calculator.BasicOperations;
using Calculator;

namespace Calculator.Calculate
{
    public class FazerCalculo
    {
        public Soma Soma { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }
        public Divisao Divisao { get; private set; }

        public FazerCalculo()
        {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Multiplicacao = new Multiplicacao();
            this.Divisao = new Divisao();
        }
    }
}