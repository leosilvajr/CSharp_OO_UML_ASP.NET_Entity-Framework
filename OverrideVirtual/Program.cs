using OverrideVirtual.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideVirtual
{
    //Sobreposição ou Sobrescrita

    /*VIRTUAL
     * Para que um método comun (não abstrato) possa ser sobreposto, deve ser incluido o prefixo "virtual"   
     */

    /*OVERRIDE
     * Ao sobrescrever um método, devemos incluir nele o prefixo "overrride".
     */

    public class Program
    {

        /*Suponha as seguintes regras para saque:
         * CONTA COMUM: Taxa 5.00;
         * CONTA POUPANÇA: Taxa 0;
         */

        //Resposta: Sobrescrevendo o Metodo Withdraw na subclasse SavinsAccount
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001 ,"Leo", 500.0);
            Account acc2 = new SavingsAccount(1002,"Maria",500.0,0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
