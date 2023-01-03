using DelegateMulticast.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulticast
{
    delegate void BinaryNumericOpration(double n1, double n2);  
     class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //Delegate guardando a referencia para duas funções
            BinaryNumericOpration op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(a, b);
            op.Invoke(a, b);
        }
    }
}
