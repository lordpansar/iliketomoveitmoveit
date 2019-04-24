using Microsoft.AspNetCore.Mvc;
using MoveIT.MVC.Interfaces;
using MoveIT.MVC.Models;

namespace MoveIT.MVC.Controllers
{
    public class OfferController : Controller
    {
        private readonly IOfferService _offerservice;

        public OfferController(IOfferService offerService)
        {
            _offerservice = offerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OfferViewModel viewModel)
        {
            var model = _offerservice.CalculateOffer(viewModel);
            return View("Details", model);
        }

        [HttpGet]
        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            var model = _offerservice.GetOfferById(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(OfferViewModel model)
        {
            return View(model);
        }
    }
}
