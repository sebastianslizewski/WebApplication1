using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wymiana_Kart_TCG.Models;
using Wymiana_Kart_TCG.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wymiana_Kart_TCG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICardRepository _cardRepository;

        public HomeController(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CardDealOfTheWeek = _cardRepository.CardDealOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
