using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() 
        {
        } 
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number,holder,balance)
        {
            InterestRate = interestRate;    
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount)
        {
            //base.WithDraw(amount); //Reaproveita o que acontece no Metodo WithDraw

            Balance -= 2.0; //Ignora a taxa dos 5.00 da Conta comum e muda pra 2.0
        }
    }
}
