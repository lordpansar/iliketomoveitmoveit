using MoveIT.API.Interfaces;
using MoveIT.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoveIT.API.Services
{
    public class OfferService : IOfferService
    {
        public OfferService()
        {
            
        }

        public void CalculateOffer(Offer offer)
        {
            double price;

            var distancePrice = CalculateDistancePrice(offer.Distance);
        }

        public double CalculateDistancePrice(double distance)
        {
            if(distance < 0)
            {
                return 0;
            }

            else if(distance >= 0 && distance < 50)
            {
                return 1000 + (distance * 10);
            }

            else if(distance >= 50 && distance < 100)
            {
                return 5000 + (distance * 8);
            }

            else
            {
                return 10000 + (distance * 7);
            }
        }

        public Offer GetOfferById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Offer> GetOffers()
        {
            throw new NotImplementedException();
        }


    }
}