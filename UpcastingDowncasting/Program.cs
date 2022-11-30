using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    /*UPCASTING 
     * Casting da subclasse para superclasse
     * Uso comum: polimorfismo
     */

    /*DOWNCASTING
     * Casting da superclasse para subclasse
     * Palavra as
     * Palavra is
     * Uso comum: métodos que recebem parametros genericos(Ex: Equals)
     */


    public class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Leo", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING - CONVERSAO DA SUPERCLASSE PARA A SUBCLASSE
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Leozera", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Samuel", 0.0, 0.01);

            //DOWNCASTING - CONVERSÃO DA SUBCLASSE PARA SUPERCLASSE
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //InvalidCastException
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            //Ultilizando o is
            if (acc3 is BusinessAccount)  //acc3 é uma instancia de BusinessAccout ?
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                //ou
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update! ");
            }
            
        }
    }
}
