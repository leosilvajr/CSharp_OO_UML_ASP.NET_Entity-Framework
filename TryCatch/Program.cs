using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite N1: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Digite N2: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine("Resultado: " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Error: {e.Message}");                        
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
        }
    }
}
