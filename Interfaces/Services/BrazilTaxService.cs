
namespace Interfaces.Services
{
    public class BrazilTaxService : ITaxService //Realização da Interface
    {
        public double Tax(double amount)
        {
            /*
             * Para quantias até 100.00 o Imposto é 20%
             * Para quantias maior do que 100.00 o Imposto é 15% 
             */
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
