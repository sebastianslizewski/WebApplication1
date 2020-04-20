using Microsoft.AspNetCore.Mvc;
using Wymiana_Kart_TCG.Models;
using Wymiana_Kart_TCG.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wymiana_Kart_TCG.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardRepository _cardRepository;
        private readonly ICardCategoryRepository _cardCategoryRepositoryRepository;

        public CardController(ICardRepository cardRepository, ICardCategoryRepository iCardCategoryRepository)
        {
            _cardRepository = cardRepository;
            _cardCategoryRepositoryRepository = iCardCategoryRepository;
        }

        public ViewResult List()
        {
            CardsListViewModel cardsListViewModel = new CardsListViewModel();
            cardsListViewModel.Cards = _cardRepository.AllCards;
            cardsListViewModel.CurrentCategory = "Pokemon";
            return View(cardsListViewModel);
        }

        public IActionResult Details(int id)
        {
            var card = _cardRepository.GetCardById(id);
            if (card == null)
                return NotFound();
            return View(card);
        }
    }
}
