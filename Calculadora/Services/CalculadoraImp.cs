using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int x, int y) {
            return x + y;
        }

        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }
    }
}