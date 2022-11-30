using Enumeracoes.Entities;
using System;
using Enumeracoes.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            string txt = OrderStatus.Processing.ToString(); //Convertendo Texto do Enum para toString()
            Console.WriteLine(txt);

            //Convertendo de String para Enum                               //Nome tem que ser igual da classe Enum
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Shipped");
            Console.WriteLine(os);

        }
    }
}
