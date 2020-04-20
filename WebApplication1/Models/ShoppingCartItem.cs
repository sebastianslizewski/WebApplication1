using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wymiana_Kart_TCG.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Card Card { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
