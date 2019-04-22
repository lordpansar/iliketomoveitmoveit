using MoveIT.API.Models;
using System.Collections.Generic;

namespace MoveIT.API.Interfaces
{
    public interface IOfferService
    {
        List<Offer> GetOffers();

        Offer GetOfferById(int id);

        void CalculateOffer(Offer offer);

        double CalculateDistancePrice(double distance);
    }
}
