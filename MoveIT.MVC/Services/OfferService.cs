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
        private readonly IOfferRepository _offerRepository;

        public OfferService(IOfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }

        public OfferViewModel CalculateOffer(OfferViewModel model)
        {
            model.Offer.Price = new Price();
            model.Offer.Price.DistanceCost = CalculateDistancePrice(model.Offer.Distance);
            model.Offer.Price.NoOfCars = CalculateNumberOfCars(model.Offer.LivingArea, model.Offer.AuxArea);
            model.Offer.Price.PianoCost = CalculatePianoCost(model.Offer.HasPiano);
            model.Offer.Price.TotalCost = (model.Offer.Price.DistanceCost * model.Offer.Price.NoOfCars) + model.Offer.Price.PianoCost;

            return model;
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

        public OfferViewModel GetOfferById(int id)
        {
            var model = new OfferViewModel();
            model.Offer = _offerRepository.GetOfferById(id);
            model.Client = new Client
            {
                Name = "Pelle Testsson",
                Email = "pelle@test.se",
                Phone = "012-3456789"
            };

            return model;
        }

        public List<Offer> GetOffers()
        {
            throw new NotImplementedException();
        }
    }
}