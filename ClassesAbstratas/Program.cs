using ClassesAbstratas.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesAbstratas
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Eu na consigo Instanciar a classe Account, porem consigo criar uma lista.;
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "ALEX", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "MARIA", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "BOB", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "ANNA", 500.0, 500.0));

            double sum = 0.0;
            foreach ( Account acc in  list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("TOTAL BALANCE: "+ sum.ToString("F2",CultureInfo.InvariantCulture));

            //Metodo de forma Polimorfica
            foreach (Account acc in list)
            {
                acc.WithDraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Update balance for account: "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F", CultureInfo.InvariantCulture)
                    );
            }

        }
    }
}
