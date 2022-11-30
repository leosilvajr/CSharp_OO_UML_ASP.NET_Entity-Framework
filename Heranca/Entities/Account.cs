using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    public class Account
    {
        public int Number { get; private set; }//get Permite acessar, porem  o Private set não permite alterar
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //protected possibilita que o saldo só pode ser alterando dentro    
                                                                            //da classe ou de uma subclasse de Herança
        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
                    //Saque
        public void WithDraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;  
        }
    }

}
