using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideVirtual.Entities
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
        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5.0; //Adicionado a Taxa padrão de Saque 5.0 para Conta Comum
        }
        public void Deposit(double amount)
        {
            Balance += amount;  
        }
    }

}
