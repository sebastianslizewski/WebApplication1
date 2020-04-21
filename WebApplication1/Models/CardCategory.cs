using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Wymiana_Kart_TCG.Models
{
    public class CardCategory
    {
        [Key]
        public int CardCategoryId { get; set; }
        public string CardCategoryName { get; set; }
        public string CardDescription { get; set; }
        public List<Card> Cards { get; set; }
    }
}
