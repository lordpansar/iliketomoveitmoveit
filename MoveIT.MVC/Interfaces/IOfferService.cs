using MoveIT.Models.Models;
using MoveIT.MVC.Models;
using System.Collections.Generic;

namespace MoveIT.MVC.Interfaces
{
    public interface IOfferService
    {
        List<Offer> GetOffers();

        OfferViewModel GetOfferById(int id);

        OfferViewModel CalculateOffer(OfferViewModel offer);

        double CalculateDistancePrice(double distance);

        int CalculateNumberOfCars(double livingArea, double auxArea);

        int CalculatePianoCost(bool hasPiano);
    }
}
