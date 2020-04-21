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

        //public IActionResult List()
        //{
        //    CardsListViewModel cardsListViewModel = new CardsListViewModel();
        //    cardsListViewModel.Cards = _cardRepository.AllCards;

        //    cardsListViewModel.CurrentCategory = "AllCards";
        //    return View(cardsListViewModel);
        //}
        public IActionResult Details(int id)
        {
            var card = _cardRepository.GetCardById(id);
            if (card == null)
                return NotFound();

            return View(card);
        }

        public ViewResult List(string category)
        {
            IEnumerable<Card> cards;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                cards = _cardRepository.AllCards.OrderBy(c => c.CardId);
                currentCategory = "All cards";
            }
            else
            {
                cards = _cardRepository.AllCards.Where(c => c.CardCategory.CardCategoryName == category)
                    .OrderBy(c => c.CardId);
                currentCategory = _cardCategoryRepository.AllCardCategories.FirstOrDefault(c => c.CardCategoryName == category)?.CardCategoryName;
            }

            return View(new CardsListViewModel
            {
                Cards = cards,
                CurrentCategory = currentCategory
            });
        }
    }
}
