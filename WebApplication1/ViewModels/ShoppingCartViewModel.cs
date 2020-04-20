using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wymiana_Kart_TCG.Models;

namespace Wymiana_Kart_TCG.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
