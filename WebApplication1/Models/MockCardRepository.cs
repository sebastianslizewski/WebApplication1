using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wymiana_Kart_TCG.Models
{
    public class MockCardRepository: ICardRepository
    {
        private readonly  ICardCategoryRepository _iCardCategoryRepository = new MockCardCategoryRepository();
        public IEnumerable<Card> AllCards =>

        new List<Card>
        {
            new Card {CardId = 1, CardName = "Alakazam" , CardPrice = 10 , CardShortDescription = "Alakazam card", CardLongDescription = "Long Description Alakazam card", CardOtherDescription = "Other description Alakazam card ", CardCategory = _iCardCategoryRepository.AllCardCategories.ToList()[0] , CardImgThumbnailUrl="https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg", CardImgUrl = "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces"},
            new Card {CardId = 2, CardName = "Charizard" , CardPrice = 20 , CardShortDescription = "Charizard card", CardLongDescription = "Long Description Charizard card", CardOtherDescription = "Other description Charizard card ", CardCategory = _iCardCategoryRepository.AllCardCategories.ToList()[1], CardImgThumbnailUrl="https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg",CardImgUrl = "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces" },
            new Card {CardId = 3, CardName = "Venusaur" , CardPrice = 30 , CardShortDescription = "Venusaur card", CardLongDescription = "Long Description Venusaur card", CardOtherDescription = "Other description Venusaur card ", CardCategory = _iCardCategoryRepository.AllCardCategories.ToList()[2], CardImgThumbnailUrl="https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg",CardImgUrl = "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces" },

        };

        public IEnumerable<Card> CardDealOfTheWeek { get; }
        public Card GetCardById(int cardId)
        {
            return AllCards.FirstOrDefault(p => p.CardId == cardId);
        }
    }
}
