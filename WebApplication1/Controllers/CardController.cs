using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Wymiana_Kart_TCG.Models;
using Wymiana_Kart_TCG.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wymiana_Kart_TCG.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardRepository _cardRepository;
        private readonly ICardCategoryRepository _cardCategoryRepository;

        public CardController(ICardRepository cardRepository, ICardCategoryRepository iCardCategoryRepository)
        {
            _cardRepository = cardRepository;
            _cardCategoryRepository = iCardCategoryRepository;
        }
        


        public ViewResult List(string category)
        {
            IEnumerable<Card> pies;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _cardRepository.AllCards.OrderBy(p => p.CardId);
                currentCategory = "All cards";
            }
            else
            {
                pies = _cardRepository.AllCards.Where(p => p.CardCategory.CardCategoryName == category)
                    .OrderBy(p => p.CardId);
                currentCategory = _cardCategoryRepository.AllCardCategories.FirstOrDefault(c => c.CardCategoryName == category)?.CardCategoryName;
            }

            return View(new CardsListViewModel
            {
                Cards = pies,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var pie = _cardRepository.GetCardById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
