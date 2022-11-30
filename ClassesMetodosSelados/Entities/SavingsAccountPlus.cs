using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodosSelados.Entities
{   //Tipo de uma conta poupança mais especializado ainda.

    //Com a linha abaixo o compliador vai dar erro, pois a classe  SavingsAccount está protegida por ser sealed.
    //public class SavingsAccountPlus : SavingsAccount
    public class SavingsAccountPlus 
    {
    }
}
