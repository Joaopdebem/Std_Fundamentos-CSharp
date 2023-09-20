using System;

namespace Calculator.BasicOperations
{
    public class Divisao
    {
        public float Calcular(float dividendo, float divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividendo / divisor;
        }
    }
}
