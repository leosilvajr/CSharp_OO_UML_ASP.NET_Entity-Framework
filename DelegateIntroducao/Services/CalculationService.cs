using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateIntroducao.Services
{
     class CalculationService
    {
        public static double Max(double x, double y)
        {
            //Retorna o maior valor entre x e y
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            //Retorna soma entre x e y 
            return x + y;
        }

        public static double Square(double x)
        {
            //Retorna o numero x ao quadrado
            return x * x;
        }
    }
}
