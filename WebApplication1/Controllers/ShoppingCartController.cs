using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Wymiana_Kart_TCG.Models;
using Wymiana_Kart_TCG.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wymiana_Kart_TCG.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICardRepository _cardRepository;

        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICardRepository cardRepository, ShoppingCart shoppingCart)
        {
            _cardRepository = cardRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToShoppingCart(int cardId)
        {
            var selectedCard = _cardRepository.AllCards.FirstOrDefault(c => c.CardId == cardId);

            if (selectedCard != null)
            {
                _shoppingCart.AddToCart(selectedCard, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int cardId)
        {
           var selectedCard = _cardRepository.AllCards.FirstOrDefault(c => c.CardId == cardId);

            if (selectedCard != null)
            {
                _shoppingCart.RemoveFromCart(selectedCard);
            }
            return RedirectToAction("Index");
        }
    }
}

