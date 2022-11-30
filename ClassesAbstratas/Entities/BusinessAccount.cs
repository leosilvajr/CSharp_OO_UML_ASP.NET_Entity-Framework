using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas.Entities
{
    //Classe  BusinessAccount  vai ter tudo que a classe Account possui (HERANÇA)
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }
                                                                            //CHAMAR CONSTRUTOR DA SUPERCLASSE Account
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base (number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        //Emprestimo
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)           
                Balance += amount;
            
        }
    }
}
