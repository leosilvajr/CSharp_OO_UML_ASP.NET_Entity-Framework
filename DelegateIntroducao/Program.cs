using DelegateIntroducao.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateIntroducao
{
    //Declaração do Delegate: ele vai ser uma referencia para uma função que recebe dois valores doubles
    // e retorna um valor double
    delegate double BinaryNumericOperation(double n1, double n2);
    internal class Program
    {

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result =op(a, b);
            Console.WriteLine(result);
        }
    }

}
