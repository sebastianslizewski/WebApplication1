using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wymiana_Kart_TCG.Models
{
    public interface ICardRepository
    {
        IEnumerable<Card> AllCards { get; }
        IEnumerable<Card> CardDealOfTheWeek { get; }
        Card GetCardById(int cardId);
    }
}
