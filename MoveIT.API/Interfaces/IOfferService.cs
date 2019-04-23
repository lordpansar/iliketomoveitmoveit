using MoveIT.API.Models;
using System.Collections.Generic;

namespace MoveIT.API.Interfaces
{
    public interface IOfferService
    {
        List<Offer> GetOffers();

        Offer GetOfferById(int id);

        Offer CalculateOffer(Offer offer);

        double CalculateDistancePrice(double distance);

        int CalculateNumberOfCars(double livingArea, double auxArea);

        int CalculatePianoCost(bool hasPiano);
    }
}
