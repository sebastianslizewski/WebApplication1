using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Wymiana_Kart_TCG.Models;

namespace Wymiana_Kart_TCG.Models
{
    public class Card
    {
        public int CardId { get; set; }  
        public string CardName { get; set; }
        public string CardShortDescription { get; set; }
        public string CardLongDescription { get; set; }
        public string CardOtherDescription { get; set; }
        public int CardPrice { get; set; }
        public string CardImgUrl { get; set; }
        public string CardImgThumbnailUrl { get; set; }
        public bool IsCardDealOfTheWeek { get; set; }
        public bool IsCardAvailableToTrade { get; set; }
        public int CardCategoryId { get; set; }
        public  CardCategory CardCategory { get; set; }
        public string Notes { get; set; }

    }
}
