using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operacoes
{
    public class Divisao
    {
        public double Calculadora(double n1, double n2)
        {
            if (n2 == 0)
            {
                return 0;
            }
            else
            {
                return n1 / n2;
            }
        }
    }
}
