using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wymiana_Kart_TCG.Models
{
    public class MockCardCategoryRepository: ICardCategoryRepository
    {
        public IEnumerable<CardCategory> AllCardCategories =>
            new List<CardCategory>
            {
                new CardCategory {CategoryId = 1, CardCategoryName = "Pokemon", CardDescription = "All Pokemon Cards"},
                new CardCategory {CategoryId = 2, CardCategoryName = "MTG", CardDescription = "All Magic The Gathering Cards"},
                new CardCategory {CategoryId = 3, CardCategoryName = "Yugioh", CardDescription = "All YuGiOh Cards"}
            };
    }
}
