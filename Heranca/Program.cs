using Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account= new BusinessAccount(8010, "Leo", 100.0, 500.0);

            Console.WriteLine(account.Balance);
        }
    }
}
