using MoveIT.MVC.Interfaces;
using MoveIT.Models.Models;
using MoveIT.Models.Models.Enums;
using System;
using System.Collections.Generic;
using MoveIT.MVC.Models;

namespace MoveIT.MVC.Services
{
    public class OfferService : IOfferService
    {
        public OfferService()
        {
            
        }

        public OfferViewModel CalculateOffer(OfferViewModel offer)
        {
            var distancePrice = CalculateDistancePrice(offer.Offer.Distance);
            var cars = CalculateNumberOfCars(offer.Offer.LivingArea, offer.Offer.AuxArea);
            var pianoCost = CalculatePianoCost(offer.Offer.HasPiano);
            
            offer.Offer.PriceIncludingVAT = (distancePrice * cars) + pianoCost;

            return offer;
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

        public int CalculateNumberOfCars(double livingArea, double auxArea)
        {
            var totalArea = livingArea + (auxArea * 2);
            int noOfCars = 0;

            if(totalArea <= 0)
            {
                return noOfCars;
            }

            else if (totalArea > 0 && totalArea < 50)
            {
                noOfCars = 1;
            }

            else if (totalArea >= 50 && totalArea < 100)
            {
                noOfCars = 2;
            }

            else if (totalArea >= 100 && totalArea < 150)
            {
                noOfCars = 3;
            }

            else
            {
                noOfCars = 4;
            }

            return noOfCars;
        }

        public int CalculatePianoCost(bool hasPiano)
        {
            if (!hasPiano)
            {
                return 0;
            }
            else
            {
                return 5000;
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