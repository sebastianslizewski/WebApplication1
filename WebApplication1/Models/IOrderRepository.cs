using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wymiana_Kart_TCG.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }

}
