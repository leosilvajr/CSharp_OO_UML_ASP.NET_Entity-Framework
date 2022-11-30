using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes.Entities.Enums
{
    public enum OrderStatus : int
    {
        PendingPayment = 0,  //Pagamento Pendente
        Processing = 1,      //Processando
        Shipped = 2,        //Enviado
        Delivered = 3       //Entregue

    }
}
