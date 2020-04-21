using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wymiana_Kart_TCG.Models;

namespace Wymiana_Kart_TCG.Components
{
    public class CategoryMenu: ViewComponent
    {
        private readonly ICardCategoryRepository _cardCategoryRepository;

        public CategoryMenu(ICardCategoryRepository cardCategoryRepository)
        {
            _cardCategoryRepository = cardCategoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cardCategories = _cardCategoryRepository.AllCardCategories.OrderBy(c => c.CardCategoryName);
            return View(cardCategories);
        }
    }
}
