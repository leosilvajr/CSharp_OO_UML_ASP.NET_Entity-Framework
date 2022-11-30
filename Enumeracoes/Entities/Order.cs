using Enumeracoes.Entities.Enums;
using System;


namespace Enumeracoes.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        //Propriedade do tipo Status da classe enum OrderStatus
        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;  
        }
    }
}
