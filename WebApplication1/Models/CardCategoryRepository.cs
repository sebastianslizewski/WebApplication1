using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wymiana_Kart_TCG.Models;

namespace Wymiana_Kart_TCG.Models
{
    public class CardCategoryRepository: ICardCategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CardCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<CardCategory> AllCardCategories => _appDbContext.CardCategories;
    }
}
