using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wymiana_Kart_TCG.Models;

namespace Wymiana_Kart_TCG.Models
{
    public class CardRepository: ICardRepository
    {
        private readonly AppDbContext _appDbContext;

        public CardRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Card> AllCards
        {
            get { return _appDbContext.Cards.Include(c => c.CardCategory); }
        }

        public IEnumerable<Card> CardDealOfTheWeek
        {
            get { return _appDbContext.Cards.Include(c => c.CardCategory).Where(p => p.IsCardDealOfTheWeek); }
        }
        public Card GetCardById(int cardId)
        {
            return _appDbContext.Cards.FirstOrDefault(p => p.CardId == cardId);
        }
    }
}
