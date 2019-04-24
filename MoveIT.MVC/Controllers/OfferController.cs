using Microsoft.AspNetCore.Mvc;
using MoveIT.MVC.Interfaces;
using MoveIT.MVC.Models;

namespace MoveIT.MVC.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
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
        public IActionResult Index(OfferViewModel model)
        {
            _offerservice.CalculateOffer(model);
            return View(model);
        }

        [HttpPost]
        public void Offer(OfferViewModel offer)
        {
            _offerservice.CalculateOffer(offer);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
